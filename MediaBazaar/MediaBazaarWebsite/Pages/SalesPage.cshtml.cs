using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;
using BusinessLogicLayer.Interfaces;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using BusinessLogicLayer;
using System.Linq;
using DTOLayer;
using Microsoft.Extensions.Logging;

namespace MediaBazaarWebsite.Pages
{
    public class SalesPageModel : PageModel
    {
        public List<Product> Products { get; set; } = new List<Product>();
        public HashSet<int> ProductsWithRestockRequestByCurrentUser { get; set; } = new HashSet<int>();
        public Dictionary<string, string> ProductImages { get; set; } = new Dictionary<string, string>();
        private readonly IProductManager _productManager;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IRestockRequestManager _restockRequestManager;

        // Google images API specifics
        private const string ApiKey = "AIzaSyAViOgtGCt2cHlvDsj2KeykuFpXPPPl11M";
        private const string CseId = "431c337daed7f4a02";

        public SalesPageModel(IProductManager productManager, IHttpClientFactory httpClientFactory, IRestockRequestManager restockRequestManager)
        {
            _productManager = productManager;
            _httpClientFactory = httpClientFactory;
            _restockRequestManager = restockRequestManager;
        }

        public async Task<IActionResult> OnGetAsync()
        {
            Products = _productManager.GetAllProducts();
            var userName = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value ?? "Unknown";
            foreach (var product in Products)
            {
                var searchQuery = $"{product.Model} {ExtractKeywords(product.Description)}";
                var imageUrl = await FetchImageUrlFromGoogleAsync(searchQuery);
                ProductImages[product.Model] = imageUrl;

                // Check if a restock request exists for this product by the current user
                var restockRequest = await _restockRequestManager.GetRestockRequestByUserAndProductAsync(userName, product.Id);
                if (restockRequest != null)
                {
                    ProductsWithRestockRequestByCurrentUser.Add(product.Id);
                }
            }
            return Page();
        }

        // Submit restock request method
        public async Task<IActionResult> OnPostRequestRestockAsync(int productId, int requestedQuantity)
        {
            var userName = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value ?? "1";
            var request = new RestockRequestDTO
            {
                ProductId = productId,
                RequestedQuantity = requestedQuantity,
                Status = "Pending",
                RequestDate = DateTime.Now,
                SenderName = userName
            };

            try
            {
                _restockRequestManager.AddRestockRequest(request);
                TempData["Message"] = "Restock request submitted successfully.";
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = $"Error submitting restock request: {ex.Message}";
            }

            return RedirectToPage(); // Use redirect to avoid form resubmission
        }

        // Methods responsible for the Google Images API for displaying product images
        public async Task<string> FetchImageUrlFromGoogleAsync(string searchQuery)
        {
            var client = _httpClientFactory.CreateClient();
            var requestUri = $"https://www.googleapis.com/customsearch/v1?q={Uri.EscapeDataString(searchQuery)}&cx={CseId}&searchType=image&key={ApiKey}&num=1";

            var response = await client.GetAsync(requestUri);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var jsonDoc = JsonDocument.Parse(content);
                if (jsonDoc.RootElement.TryGetProperty("items", out var items) && items.GetArrayLength() > 0)
                {
                    var imageUrl = items[0].GetProperty("link").GetString();
                    return imageUrl;
                }
            }
            return "/img/product_placeholder.png";
        }

        private string ExtractKeywords(string description)
        {
            var significantWords = description.Split(new[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries)
                                              .Where(word => word.Length > 4)
                                              .Distinct()
                                              .Take(5);
            return string.Join(" ", significantWords);
        }
    }
}

using MediaBazaar.Classes;
using BusinessLogicLayer;
using BusinessLogicLayer.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MediaBazaarWebsite.Pages
{
    public class AdminPageModel : PageModel
    {
        internal EmployeeManager _employeeManager;
        private readonly IProductManager _productManager;

        public int Hired1Month;
        public int Hired3Month;
        public int Hired6Month;
        public int Hired1Year;
        public int Deactivated;
        public int Fired1Month;
        public int Fired3Month;
        public int Fired6Month;
        public int Fired1Year;

        public int TotalProducts { get; private set; }
        public int TotalStock { get; private set; }
        public int OutOfStockProducts { get; private set; }
        public int InStockProducts { get; private set; }

        public AdminPageModel(EmployeeManager employeeManager, IProductManager productManager)
        {
            _employeeManager = employeeManager;
            _productManager = productManager;

            Hired1Month = _employeeManager.HiredInTimeFrame(1);
            Hired3Month = _employeeManager.HiredInTimeFrame(3);
            Hired6Month = _employeeManager.HiredInTimeFrame(6);
            Hired1Year = _employeeManager.HiredInTimeFrame(12);
            Deactivated = _employeeManager.DeactivatedEmployees();
            Fired1Month = _employeeManager.FiredInTimeFrame(1);
            Fired3Month = _employeeManager.FiredInTimeFrame(3);
            Fired6Month = _employeeManager.FiredInTimeFrame(6);
            Fired1Year = _employeeManager.FiredInTimeFrame(12);

            var products = _productManager.GetAllProducts();
            TotalProducts = products.Count;
            TotalStock = products.Sum(product => product.Stock);
            OutOfStockProducts = products.Count(product => product.Stock <= 0);
            InStockProducts = products.Count(product => product.Stock > 0);
        }

        public void OnGet()
        {
        }
    }
}

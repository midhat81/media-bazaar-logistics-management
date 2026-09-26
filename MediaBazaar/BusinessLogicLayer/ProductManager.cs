using BusinessLogicLayer.Interfaces;
using DataAccessLayer;
using DTOLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class ProductManager : IProductManager
    {
        private ProductDAL productDAL;
        public List<Product> Products { get; private set; }
        public ProductManager()
        {
            productDAL = new ProductDAL();
            GetAllProducts();
        }

        public void AddProduct(Product newProduct)
        {
            var productDTO = TransformProductToDTO(newProduct);
            productDAL.CreateProduct(productDTO);
        }

        public Product GetProductById(int productId)
        {
            var productDTO = productDAL.GetProduct(productId);
            return TransformDTOToProduct(productDTO);
        }

        public void UpdateProduct(Product updatedProduct)
        {
            var productDTO = TransformProductToDTO(updatedProduct);
            productDAL.UpdateProduct(productDTO);
        }

        public void DeleteProduct(int productId)
        {
            productDAL.DeleteProduct(productId);
        }

        public List<Product> GetAllProducts()
        {
            try
            {
                var productDTOs = productDAL.GetAllProducts();
                Products = productDTOs.Select(TransformDTOToProduct).ToList();
                return Products;
            }
            catch (Exception)
            {
                return new List<Product>();
            }
        }

        private Product TransformDTOToProduct(ProductDTO productDTO)
        {
            return new Product(productDTO.Id, productDTO.Model, productDTO.Brand, productDTO.Price, productDTO.Description, productDTO.Weight, productDTO.Height, productDTO.Width, productDTO.Depth, (ProductCategoryEum)productDTO.Category, productDTO.Stock);
        }

        private ProductDTO TransformProductToDTO(Product product)
        {
            return new ProductDTO { Id = product.Id, Model = product.Model, Brand = product.Brand, Price = product.Price, Description = product.Description, Weight = product.Weight, Height = product.Height, Width = product.Width, Depth = product.Depth, Category = (int)product.Category, Stock = product.Stock };
        }
    }

}

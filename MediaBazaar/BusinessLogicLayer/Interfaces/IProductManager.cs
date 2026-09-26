using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Interfaces
{
	public interface IProductManager
	{
		List<Product> GetAllProducts();
		Product GetProductById(int id);
		void AddProduct(Product product);
		void UpdateProduct(Product product);
		void DeleteProduct(int id);
	}
}

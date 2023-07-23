using Microsoft.AspNetCore.Mvc;
using MyVillageKartAPI.DataInterface;
using MyVillageKartAPI.Models;

namespace MyVillageKartAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductsController : ControllerBase
	{
		IProductsDataManager _manager;
		public ProductsController(IProductsDataManager manager)
		{
			_manager = manager;
		}
		[HttpGet]
		public IEnumerable<Products>? Get()
		{
			return _manager.GetProducts();
		}

		[HttpGet("{id}")]
		public Products? Get(int id)
		{
			return _manager.GetProductsById(id);
		}

		[HttpPost]
		public bool Post([FromBody] Products value)
		{
			return _manager.CreateProducts(value);
		}

		[HttpPut("{id}")]
		public bool Put(int id, [FromBody] Products value)
		{
			return _manager.UpdateProducts(value);
		}

		[HttpDelete("{id}")]
		public bool Delete(int id)
		{
			return _manager.DeleteProducts(id);
		}
	}
}

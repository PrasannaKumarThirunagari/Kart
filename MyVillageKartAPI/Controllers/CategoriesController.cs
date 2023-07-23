using Microsoft.AspNetCore.Mvc;
using MyVillageKartAPI.DataInterface;
using MyVillageKartAPI.Models;

namespace MyVillageKartAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CategoriesController : ControllerBase
	{
		ICategoriesDataManager _manager;
		public CategoriesController(ICategoriesDataManager manager)
		{
			_manager = manager;
		}

		[HttpGet]
		public IEnumerable<Categories>? Get()
		{
			return _manager.GetCategories();
		}

		[HttpGet("{id}")]
		public Categories? Get(int id)
		{
			return _manager.CategoriesById(id);
		}

		[HttpPost]
		public bool Post([FromBody] Categories value)
		{
			return _manager.CreateCategories(value);
		}

		[HttpPut("{id}")]
		public bool Put(int id, [FromBody] Categories value)
		{
			return _manager.UpdateCategories(value);
		}

		[HttpDelete("{id}")]
		public bool Delete(int id)
		{
			return _manager.DeleteCategories(id);
		}
	}
}

using Microsoft.AspNetCore.Mvc;
using MyVillageKartAPI.DataInterface;
using MyVillageKartAPI.Models;

namespace MyVillageKartAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class UsersController : ControllerBase
	{
		IUserDataManager _manager;
		public UsersController(IUserDataManager manager)
		{
			_manager = manager;
		}

		[HttpGet]
		public IEnumerable<Users> Get()
		{
			return _manager.GetUsers();
		}

		[HttpGet("{id}")]
		public Users Get(int id)
		{
			return _manager.UsersById(id);
		}

		[HttpPost]
		public bool Post([FromBody] Users value)
		{
			return _manager.CreateUsers(value);
		}

		[HttpPut("{id}")]
		public bool Put(int id, [FromBody] Users value)
		{
			return _manager.UpdateUsers(value);
		}

		[HttpDelete("{id}")]
		public bool Delete(int id)
		{
			return _manager.DeleteUsers(id);
		}
	}
}

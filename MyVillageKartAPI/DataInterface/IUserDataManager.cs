using MyVillageKartAPI.Models;

namespace MyVillageKartAPI.DataInterface
{
    public interface IUserDataManager
    {
        #region MyRegion
        List<Users> GetUsers();
        Users UsersById(int id);
        bool UpdateUsers(Users updateUsers);
        bool CreateUsers(Users createUsers);
		bool DeleteUsers(int deleteUserID);
		#endregion
	}
}

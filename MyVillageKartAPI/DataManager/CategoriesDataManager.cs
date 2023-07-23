using MyVillageKartAPI.DataInterface;
using MyVillageKartAPI.Models;

namespace MyVillageKartAPI.DataManager
{
	public class CategoriesDataManager : ICategoriesDataManager
	{
		public Categories? CategoriesById(int id)
		{
			return DataBase.GetData().CategoriesList?.FirstOrDefault(x => x.CategoriesID == id);
		}

		public bool CreateCategories(Categories createCategories)
		{
			throw new NotImplementedException();
		}

		public bool DeleteCategories(int deleteCategorieID)
		{
			throw new NotImplementedException();
		}

		public List<Categories>? GetCategories()
		{
			return DataBase.GetData().CategoriesList;
		}

		public bool UpdateCategories(Categories updateCategories)
		{
			throw new NotImplementedException();
		}
	}
}

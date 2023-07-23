using MyVillageKartAPI.Models;

namespace MyVillageKartAPI.DataInterface
{
	public interface ICategoriesDataManager
	{
		#region MyRegion
		List<Categories>? GetCategories();
		Categories? CategoriesById(int id);
		bool UpdateCategories(Categories updateCategories);
		bool CreateCategories(Categories createCategories);
		bool DeleteCategories(int deleteCategorieID);
		#endregion
	}
}

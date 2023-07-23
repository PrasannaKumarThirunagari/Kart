namespace MyVillageKartAPI.Models
{
	public class Categories
	{
		public int CategoriesID { get; set; }
		public string CategoriesName { get; set; }
		public List<Products> ProductsList { get; set; }
	}
}

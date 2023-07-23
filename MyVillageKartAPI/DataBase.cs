using MyVillageKartAPI.Models;
using System.Diagnostics;

namespace MyVillageKartAPI
{
	public static class DataBase
	{
		public static DataObject GetData()
		{
			DataObject response = new DataObject();
			response.ProductsList = new List<Products>();
			response.CategoriesList = new List<Categories>();

			List<Categories> list = new List<Categories>();
			for (int i = 0; i < 30; i++)
			{
				Categories add = new Categories
				{
					CategoriesID = i,
					CategoriesName = "Category Name" + i,
					ProductsList = new List<Products>()
				};

				list.Add(add);
				var productsList = GetProducts(i, i + 5, i);

				response.ProductsList.AddRange(productsList);
				add.ProductsList.AddRange(productsList);
			}
			response.CategoriesList.AddRange(list);
			return response;
		}

		private static List<Products> GetProducts(int start, int end, int categoryId)
		{
			List<Products> products = new List<Products>();
			for (int i = start; i < end; i++)
			{
				products.Add(new Products()
				{
					ProductId = i,
					ProductName = "Product Name" + i,
					ProductDescription = " Product Description " + i,
					ProductCategoryID = categoryId
				});
			}
			return products;
		}
	}
}

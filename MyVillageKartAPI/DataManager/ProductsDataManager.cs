using MyVillageKartAPI.DataInterface;
using MyVillageKartAPI.Models;

namespace MyVillageKartAPI.DataManager
{
	public class ProductsDataManager : IProductsDataManager
	{
		public bool CreateProducts(Products createProduct)
		{
			throw new NotImplementedException();
		}

		public bool DeleteProducts(int deleteProductsID)
		{
			throw new NotImplementedException();
		}

		public List<Products>? GetProducts()
		{
			return DataBase.GetData().ProductsList;
		}

		public Products? GetProductsById(int id)
		{
			return DataBase.GetData().ProductsList?.FirstOrDefault(x => x.ProductId == id);
		}

		public bool UpdateProducts(Products updateProduct)
		{
			throw new NotImplementedException();
		}
	}
}

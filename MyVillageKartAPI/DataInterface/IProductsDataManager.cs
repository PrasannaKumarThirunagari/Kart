using MyVillageKartAPI.Models;

namespace MyVillageKartAPI.DataInterface
{
    public interface IProductsDataManager
    {
        #region MyRegion
        List<Products>? GetProducts();
        Products? GetProductsById(int id);
        bool UpdateProducts(Products updateProduct);
        bool CreateProducts(Products createProduct);
		bool DeleteProducts(int deleteProductsID);
		#endregion
	}
}

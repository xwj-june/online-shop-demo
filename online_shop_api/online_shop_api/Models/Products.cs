using online_shop_api.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace online_shop_api.Models
{
	public class Products
	{
		public int Id { get; set; }
		public string ProductName { get; set; }
		public string ProductImageUrl { get; set; }
		public string ProductDetailImageUrl { get; set; }
		public double Price { get; set; }

		public static List<Products> GetProductList()
		{
			DataTable dt = SqlHelper.ExecuteTable("SELECT * FROM Products");
			List<Products> products = new List<Products>();
			for (int i = 0; i < dt.Rows.Count; i++)
			{
				products.Add(ToModel(dt.Rows[i]));
			}
			return products;
		}

		private static Products ToModel(DataRow dr)
		{
			Products product = new Products();
			product.Id = (int)dr["Id"];
			product.ProductName = dr["ProductName"].ToString();
			product.ProductImageUrl = dr["ProductImageUrl"].ToString();
			product.ProductDetailImageUrl = dr["ProductDetailImageUrl"].ToString();
			product.Price = (double)dr["Price"];
			return product;
		}
	}
}

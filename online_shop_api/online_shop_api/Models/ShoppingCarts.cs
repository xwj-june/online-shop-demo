using online_shop_api.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace online_shop_api.Models
{
	public class ShoppingCarts
	{
		public int Id { get; set; }
		public int Count { get; set; }
		public int ProductId { get; set; }
		public static int AddCart (int pid, int count) {
			return SqlHelper.ExecuteNonQuery($"INSERT INTO ShoppingCarts(Count, ProductId) VALUES ('{count}','{pid}')");
			
		}
	}
}

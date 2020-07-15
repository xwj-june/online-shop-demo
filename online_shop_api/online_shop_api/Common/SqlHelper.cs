using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace online_shop_api.Common
{
	public class SqlHelper
	{
		public static string Constr { get; set; }
		public static DataTable ExecuteTable(string cmdText){
			using (SqlConnection con = new SqlConnection(Constr))
			{
				con.Open();
				//cmdTetxt - sql comands
				SqlCommand cmd = new SqlCommand(cmdText, con);
				//adapter - store data from sql server
				SqlDataAdapter sda = new SqlDataAdapter(cmd);
				//data set - store data into model 
				DataSet ds = new DataSet();
				sda.Fill(ds);
				//get the first model 
				return ds.Tables[0];

			}
		}
	}
}

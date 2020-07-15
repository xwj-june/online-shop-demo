using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using online_shop_api.Models;

namespace online_shop_api.Controllers
{
    [EnableCors("any")]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public List<Products> GetProducts()
        {
            List<Products> productList = Products.GetProductList();
            return productList;            
        }

        public Products GetProductById(int id)
        {
            List<Products> productList = Products.GetProductList();
            return productList.Find(m => m.Id == id);
        }

        public int AddCart(int productId, int count)
        {
            int rows = ShoppingCarts.AddCart(productId, count);
            return rows;

        }
    }
}
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
    }
}
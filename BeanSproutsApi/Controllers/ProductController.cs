using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BeanSproutsApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace BeanSproutsApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]

    public class ProductController : ControllerBase
    {
        public static List<Product> ProductData = new List<Product>
        {
            new Product { ProductId = "P-001" , ProductName = "สีย้อมผม" , ProductCount = ""},
            new Product { ProductId = "P-002" , ProductName = "ครีมยืดผม" , ProductCount = ""},
            new Product { ProductId = "P-003" , ProductName = "ทรีกเม้นผม" , ProductCount = ""},
            new Product { ProductId = "P-004" , ProductName = "ยาดัดผม" , ProductCount = ""},
            new Product { ProductId = "P-005" , ProductName = "ครีมสระผม" , ProductCount = ""},
             new Product { ProductId = "P-006" , ProductName = "ครีมนวดผม" , ProductCount = ""},
             
        };

        [HttpGet]
        public ActionResult<IEnumerable<Product>> GetAllProduct()
        {
            return ProductData.ToList();
        }
    }

}
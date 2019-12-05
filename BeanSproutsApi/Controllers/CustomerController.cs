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

    public class CustomerController : ControllerBase
    {
        public static List<Customer> CustomerData = new List<Customer>
        {
            new Customer { CustomerId = "100101" , CustomerName = "CustomerTest01" , CustomerTel = "12345678911"},
             new Customer { CustomerId = "100102" , CustomerName = "CustomerTest02" , CustomerTel = "12345678912"},
              new Customer { CustomerId = "100103" , CustomerName = "CustomerTest03" , CustomerTel = "12345678913"},
               new Customer { CustomerId = "100104" , CustomerName = "CustomerTest04" , CustomerTel = "12345678914"},
                new Customer { CustomerId = "100105" , CustomerName = "CustomerTest05" , CustomerTel = "12345678915"}
        };

        [HttpGet]
        public ActionResult<IEnumerable<Customer>> GetAllCustomer()
        {
            return CustomerData.ToList();
        }
    }
}

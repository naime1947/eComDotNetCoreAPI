using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eComApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eComApi.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        public IActionResult GetProducts()
        {
            return Ok(new List<Product>{ 
                
                new Product{ Id=1, CategoryId=1, Name="Balti", Price = 5.5m}
            
            });
        }
    }
}
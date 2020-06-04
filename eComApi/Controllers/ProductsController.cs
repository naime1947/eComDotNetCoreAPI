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
        private readonly eComContext _context;
        public ProductsController(eComContext context)
        {
            _context = context;
        }

        public IActionResult GetProducts()
        {
            return Ok(_context.Products.ToList());
        }
    }
}
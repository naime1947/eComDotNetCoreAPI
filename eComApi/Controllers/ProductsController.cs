using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eComApi.Classes;
using eComApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

        [HttpGet]
        public async Task<IActionResult> GetProducts([FromQuery] ProductQueryParameters query )
        {
            IQueryable<Product> products = _context.Products;

            if(query.MinPrice != null && query.MaxPrice != null)
            {
                products = products.Where(p => p.Price >= query.MinPrice && p.Price <= query.MaxPrice);
            }

            if (!string.IsNullOrEmpty(query.Sku))
            {
                products = products.Where(p => p.Sku == query.Sku);
            }



            products = products.Skip(query.Size * (query.Page - 1))
                .Take(query.Size);


            return Ok( await products.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduct(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}
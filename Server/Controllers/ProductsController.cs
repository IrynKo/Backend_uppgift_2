using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Server.Data;
using Server.Models;
using Newtonsoft.Json;
using SharedLibrary;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly SqlContext _context;

        public ProductsController(SqlContext context)
        {
            _context = context;
        }

        // GET: api/Products
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
            var productsList = new List<Product>();


            foreach (var product in await _context.Products.ToListAsync())
            {

                productsList.Add(new Product
                {
                    Id = product.Id,
                    Title = product.Title,
                    Description = product.Description,
                    Price = product.Price,
                    Image = product.Image,
                    DateCreated = product.DateCreated

                });

            }

            return productsList;

        }

        // GET: api/Products/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            var product = await _context.Products.Where(x => x.Id == id).FirstOrDefaultAsync();

            if (product == null)
            {
                return NotFound();
            }

            return new OkObjectResult(new Product
            {

                Id = product.Id,
                Title = product.Title,
                Description = product.Description,
                Price = product.Price,
                Image = product.Image

            });

        }

       
        // POST: api/Products
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Product>> PostProduct(CreateProduct model)
        {
            var product = await _context.Products.Where(x => x.Title == model.Title).FirstOrDefaultAsync();
            if (product == null)
            {
                var newProduct = new Product
                {
                    Title = model.Title,
                    Description = model.Description,
                    Image = model.Image,
                    Price = model.Price,
                   
                };
                _context.Products.Add(newProduct);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetProduct", new { id = newProduct.Id }, new Product
                {
                    Id = newProduct.Id,
                    Title = newProduct.Title,
                    Description = newProduct.Description,
                    Image = newProduct.Image,
                Price = newProduct.Price
                    
                });

            }
            return new ConflictResult();

        }

        // DELETE: api/Products/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();

            return Ok(JsonConvert.SerializeObject(new { message = "Deleted" }));
        }

        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.Id == id);
        }
    }
}

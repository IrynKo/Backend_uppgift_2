using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Server.Data;
using Server.Models;
using SharedLibrary;

namespace Servers.Orders
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly SqlContext _context;

        public OrdersController(SqlContext context)
        {
            _context = context;
        }

        // GET: api/Orders
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OrderRead>>> GetOrders()
        {
            var ordersList = new List<OrderRead>();


            foreach (var order in await _context.Orders.Include(x => x.OrderDetails).ToListAsync())
            {

                ordersList.Add(new OrderRead
                {
                    Id = order.Id,
                   
                    Amount = order.Amount,
                   // OrderDetailId = order.OrderDetails.,
                    OrderDetails = order.OrderDetails,


                });

            }




            return ordersList;

           
        }

        // GET: api/Orders/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Order>> GetOrder(int id)
        {
            var order = await _context.Orders.FindAsync(id);

            if (order == null)
            {
                return NotFound();
            }

            return order;
        }

        // PUT: api/Orders/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrder(int id, Order order)
        {
            if (id != order.Id)
            {
                return BadRequest();
            }

            _context.Entry(order).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrderExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Orders
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]

        public async Task<ActionResult<OrderDetail>> PostOrder(List<CartItem> model)
        {
            //var cartItems = new List<CartItem>();
            var order = new Order()
            {
             Amount= model.Sum(x=>x.Quantity*x.Price),
                DateCreated = DateTime.Now
        };
            _context.Orders.Add(order);
            await _context.SaveChangesAsync();

            foreach (var item in model)
            {
                var orderItems = new OrderDetail()
                {
                    Quantity = item.Quantity,
                    ProductId = item.ProductId,
                    OrderId = order.Id,
                    Price = item.Price
                };
             _context.OrderDetails.Add(orderItems);
            }

            await _context.SaveChangesAsync();
            //return Ok();
            return CreatedAtAction("GetOrder", new { id = order.Id }, /*orderDetail*/ new Order {
                Id = order.Id,
                Amount= order.Amount,
                DateCreated = order.DateCreated,
                OrderDetails = order.OrderDetails

            });
        }







        // DELETE: api/Orders/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrder(int id)
        {
            var order = await _context.Orders.FindAsync(id);
            if (order == null)
            {
                return NotFound();
            }

            _context.Orders.Remove(order);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool OrderExists(int id)
        {
            return _context.Orders.Any(e => e.Id == id);
        }
    }
}

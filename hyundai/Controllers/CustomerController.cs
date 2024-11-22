using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using hyundai.Data;
using Microsoft.EntityFrameworkCore;


namespace hyundai.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly hyundaiDBContext _context;

        public CustomerController(hyundaiDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Customer>>> GetCustomer()
        {
            return Ok(await _context.Customer.ToListAsync());
        }

        [HttpGet("{id}")]
        public ActionResult<Customer> GetCustomer(int id)
        {
            var customer = _context.Customer.Find(id);
            if (customer == null)
            {
                return NotFound();
            }
            return customer;
        }


        [HttpPost]
        public async Task<ActionResult<Customer>> CreateCustomer(Customer customer)
        {
            _context.Add(customer);
            await _context.SaveChangesAsync();
            return Ok(customer);
        }

        [HttpPut]
        public async Task<ActionResult> Update(int id, Customer customer)
        {
            if (id != customer.Id)
                return BadRequest();
            _context.Entry(customer).State = EntityState.Modified;
            await _context.SaveChangesAsync();  
            return Ok();
        }

        [HttpDelete]
        public async Task<ActionResult> Delete(int id)
        {
            var customer = await _context.Customer.FindAsync(id);
            if (customer == null)
            {
                return NotFound("incorrect id");
            }
            _context.Customer.Remove(customer);
            await _context.SaveChangesAsync();
            return Ok();
        }



    }
}

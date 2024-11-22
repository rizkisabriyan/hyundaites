using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using hyundai.Data;
using Microsoft.EntityFrameworkCore;


namespace hyundai.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly hyundaiDBContext _context;

        public CarsController(hyundaiDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Cars>>> GetCars()
        {
            return Ok(await _context.Cars.ToListAsync());
        }

        [HttpGet("{id}")]
        public ActionResult<Cars> GetCars(int id)
        {
            var cars = _context.Cars.Find(id);
            if (cars == null)
            {
                return NotFound();
            }
            return cars;
        }


        [HttpPost]
        public async Task<ActionResult<Cars>> CreateCars(Cars cars)
        {
            _context.Add(cars);
            await _context.SaveChangesAsync();
            return Ok(cars);
        }

        [HttpPut]
        public async Task<ActionResult> Update(int id, Cars cars)
        {
            if (id != cars.Id)
                return BadRequest();
            _context.Entry(cars).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete]
        public async Task<ActionResult> Delete(int id)
        {
            var cars = await _context.Cars.FindAsync(id);
            if (cars == null)
            {
                return NotFound("incorrect id");
            }
            _context.Cars.Remove(cars);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}

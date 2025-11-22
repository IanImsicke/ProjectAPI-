using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectAPI;



namespace ProjectAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BreakfastFoodsController : ControllerBase
    {
        private readonly AppDbContext _db;
        public BreakfastFoodsController(AppDbContext db) => _db = db;

        // GET api/breakfastfoods?id={id}
        [HttpGet]
        public async Task<IActionResult> Get(int? id)
        {
            if (id == null || id == 0)
            {
                var list = await _db.BreakfastsFoods.OrderBy(t => t.Food_Id).Take(5).ToListAsync();
                return Ok(list);
            }

            var item = await _db.BreakfastsFoods.FindAsync(id.Value);
            if (item == null) return NotFound();
            return Ok(item);
        }

        // POST api/breakfastsfoods
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] BreakfastFoods model)
        {
            _db.BreakfastsFoods.Add(model);
            await _db.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = model.Food_Id }, model);
        }

        // PUT api/breakfastfoods/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] BreakfastFoods model)
        {
            if (id != model.Food_Id) return BadRequest();
            var exists = await _db.BreakfastsFoods.FindAsync(id);
            if (exists == null) return NotFound();
            _db.Entry(exists).CurrentValues.SetValues(model);
            await _db.SaveChangesAsync();
            return NoContent();
        }

        // DELETE api/breakfastfoods/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var item = await _db.BreakfastsFoods.FindAsync(id);
            if (item == null) return NotFound();
            _db.BreakfastsFoods.Remove(item);
            await _db.SaveChangesAsync();
            return NoContent();
        }
    }
}
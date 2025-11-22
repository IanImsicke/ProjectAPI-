using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectAPI;

namespace ProjectAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HobbiesController : ControllerBase
    {
        private readonly AppDbContext _db;
        public HobbiesController(AppDbContext db) => _db = db;

        // GET api/Hobbies?id={id}
        [HttpGet]
        public async Task<IActionResult> Get(int? id)
        {
            if (id == null || id == 0)
            {
                var list = await _db.Hobbies.OrderBy(t => t.Hobby_ID).Take(5).ToListAsync();
                return Ok(list);
            }

            var item = await _db.Hobbies.FindAsync(id.Value);
            if (item == null) return NotFound();
            return Ok(item);
        }

        // POST api/Hobbies
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Hobbies model)
        {
            _db.Hobbies.Add(model);
            await _db.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = model.Hobby_ID }, model);
        }

        // PUT api/hobbies/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] Hobbies model)
        {
            if (id != model.Hobby_ID) return BadRequest();
            var exists = await _db.Hobbies.FindAsync(id);
            if (exists == null) return NotFound();
            _db.Entry(exists).CurrentValues.SetValues(model);
            await _db.SaveChangesAsync();
            return NoContent();
        }

        // DELETE api/hobbies/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var item = await _db.Hobbies.FindAsync(id);
            if (item == null) return NotFound();
            _db.Hobbies.Remove(item);
            await _db.SaveChangesAsync();
            return NoContent();
        }
    }
}
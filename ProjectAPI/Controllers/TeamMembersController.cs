using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectAPI;

namespace ProjectAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TeamMembersController : ControllerBase
    {
        private readonly AppDbContext _db;
        public TeamMembersController(AppDbContext db) => _db = db;

        // GET api/teammembers?id={id}
        [HttpGet]
        public async Task<IActionResult> Get(int? id)
        {
            if (id == null || id == 0)
            {
                var list = await _db.TeamMembers.OrderBy(t => t.Team_Member_Id).Take(5).ToListAsync();
                return Ok(list);
            }

            var item = await _db.TeamMembers.FindAsync(id.Value);
            if (item == null) return NotFound();
            return Ok(item);
        }

        // POST api/teammembers
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] TeamMembers model)
        {
            _db.TeamMembers.Add(model);
            await _db.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = model.Team_Member_Id }, model);
        }

        // PUT api/teammembers/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] TeamMembers model)
        {
            if (id != model.Team_Member_Id) return BadRequest();
            var exists = await _db.TeamMembers.FindAsync(id);
            if (exists == null) return NotFound();
            _db.Entry(exists).CurrentValues.SetValues(model);
            await _db.SaveChangesAsync();
            return NoContent();
        }

        // DELETE api/teammembers/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var item = await _db.TeamMembers.FindAsync(id);
            if (item == null) return NotFound();
            _db.TeamMembers.Remove(item);
            await _db.SaveChangesAsync();
            return NoContent();
        }
    }
}
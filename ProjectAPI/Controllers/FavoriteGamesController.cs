using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectAPI;

namespace ProjectAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FavoriteGamesController : ControllerBase
    {
        private readonly AppDbContext _db;
        public FavoriteGamesController(AppDbContext db) => _db = db;

        // GET api/favoritegames?id={id}
        [HttpGet]
        public async Task<IActionResult> Get(int? id)
        {
            if (id == null || id == 0)
            {
                var list = await _db.FavoriteGames.OrderBy(t => t.Game_Id).Take(5).ToListAsync();
                return Ok(list);
            }

            var item = await _db.FavoriteGames.FindAsync(id.Value);
            if (item == null) return NotFound();
            return Ok(item);
        }

        // POST api/favoritegames
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] FavoriteGames model)
        {
            _db.FavoriteGames.Add(model);
            await _db.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = model.Game_Id }, model);
        }

        // PUT api/favoritegames/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] FavoriteGames model)
        {
            if (id != model.Game_Id) return BadRequest();
            var exists = await _db.FavoriteGames.FindAsync(id);
            if (exists == null) return NotFound();
            _db.Entry(exists).CurrentValues.SetValues(model);
            await _db.SaveChangesAsync();
            return NoContent();
        }

        // DELETE api/favoritegames/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var item = await _db.FavoriteGames.FindAsync(id);
            if (item == null) return NotFound();
            _db.FavoriteGames.Remove(item);
            await _db.SaveChangesAsync();
            return NoContent();
        }
    }
}
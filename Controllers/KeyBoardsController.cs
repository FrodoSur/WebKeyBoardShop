using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebKeyBoardShop.Models;

namespace WebKeyBoardShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KeyBoardsController : ControllerBase
    {
        private readonly SellContext _context;

        public KeyBoardsController(SellContext context)
        {
            _context = context;
        }

        // GET: api/KeyBoards
        [HttpGet]
        public async Task<ActionResult<IEnumerable<KeyBoard>>> GetKeyBoards()
        {
            return await _context.KeyBoards.ToListAsync();
        }

        // GET: api/KeyBoards/5
        [HttpGet("{id}")]
        public async Task<ActionResult<KeyBoard>> GetKeyBoard(int id)
        {
            var keyBoard = await _context.KeyBoards.FindAsync(id);

            if (keyBoard == null)
            {
                return NotFound();
            }

            return keyBoard;
        }

        // PUT: api/KeyBoards/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutKeyBoard(int id, KeyBoard keyBoard)
        {
            if (id != keyBoard.Id)
            {
                return BadRequest();
            }

            _context.Entry(keyBoard).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KeyBoardExists(id))
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

        // POST: api/KeyBoards
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<KeyBoard>> PostKeyBoard(KeyBoard keyBoard)
        {
            _context.KeyBoards.Add(keyBoard);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetKeyBoard", new { id = keyBoard.Id }, keyBoard);
        }

        // DELETE: api/KeyBoards/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<KeyBoard>> DeleteKeyBoard(int id)
        {
            var keyBoard = await _context.KeyBoards.FindAsync(id);
            if (keyBoard == null)
            {
                return NotFound();
            }

            _context.KeyBoards.Remove(keyBoard);
            await _context.SaveChangesAsync();

            return keyBoard;
        }

        private bool KeyBoardExists(int id)
        {
            return _context.KeyBoards.Any(e => e.Id == id);
        }
    }
}

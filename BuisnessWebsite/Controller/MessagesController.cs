
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BuisnessWebsite.DAL;
using BuisnessWebsite.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace BuisnessWebsite.Controller
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class MessagesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public MessagesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Messages
        [Authorize(Roles="Admin")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Message>>> GetMessages()
        {
            return await _context.Messages.ToListAsync();
        }

        // GET: api/Messages/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<Message>> GetMessage(int id)
        //{
        //    var message = await _context.Messages.FindAsync(id);

        //    if (message == null)
        //    {
        //        return NotFound();
        //    }

        //    return message;
        //}

        // PUT: api/Messages/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutMessage(int id, Message message)
        //{
        //    if (id != message.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(message).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!MessageExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        // POST: api/Messages
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [Authorize(Roles ="User")]
        [HttpPost]
        public async Task<ActionResult<Message>> PostMessage(Message message)
        {

            _context.Messages.Add(message);
            await _context.SaveChangesAsync();
            return Ok(message);

            // Use GetMessages since GetMessage is commented
            //return CreatedAtAction(nameof(GetMessages), new { id = message.Id }, message);
        }

        // DELETE: api/Messages/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteMessage(int id)
        //{
        //    var message = await _context.Messages.FindAsync(id);
        //    if (message == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Messages.Remove(message);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        //private bool MessageExists(int id)
        //{
        //    return _context.Messages.Any(e => e.Id == id);
        //}
    }
}

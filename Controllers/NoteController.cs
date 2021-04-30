using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using vvvas.Models;

namespace vvvas.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NoteController : Controller
    {
        [HttpPost]
        public async Task<IActionResult> Create([FromServices] AZContext context, [FromBody] Note note)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            try
            {
                await context.Notes.AddAsync(note);

                return Ok(note);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return Problem($"There was an error: {ex.Message}");
            }
        }

        [HttpGet]
        public async Task<ICollection<Note>> GetNotes([FromServices] AZContext context)
        {
            return await context.Notes.ToListAsync();
        }
    }
}
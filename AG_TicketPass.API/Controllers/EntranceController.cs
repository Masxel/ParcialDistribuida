using AG_TicketPass.API.Data;
using AG_TicketPass.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AG_TicketPass.API.Controllers
{
    [ApiController]
    [Route("/api/entrances")]

    public class EntranceController : ControllerBase
    {

        private readonly DataContext _context;

        public EntranceController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        { 
            return Ok(await _context.Tickets.ToListAsync());
        }



        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {
            var country = await _context.Tickets.FirstOrDefaultAsync(x => x.Id == id);
            if (country is null)
            {
                return NotFound();
            }

            return Ok(country);
        }


        [HttpPut]
        public async Task<ActionResult> Put(Ticket ticket)
        {
            _context.Update(ticket);
            await _context.SaveChangesAsync();
            return Ok(ticket);
        }


    }
}

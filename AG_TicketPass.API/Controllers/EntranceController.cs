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


        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetAsync(int id)
        {
            var ticket = await _context.Tickets.FirstOrDefaultAsync(x => x.Id == id);
            if (ticket == null)
            {
                return NotFound();
            }

            return Ok(ticket);
        }



    }
}

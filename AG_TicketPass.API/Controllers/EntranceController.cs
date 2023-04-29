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

        [HttpPost]
        public async Task<ActionResult> Post(Ticket ticket)
        {
            _context.Add(ticket);
            await _context.SaveChangesAsync();
            return Ok(ticket);
        }




    }
}

using AG_TicketPass.Shared.Entities;
using System.Threading;

namespace AG_TicketPass.API.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;


        public SeedDb(DataContext context)
        {
            _context = context;
        }


        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckTickets();
        }

        private async Task CheckTickets()
        {
            if (!_context.Tickets.Any())
            {
                for (int i = 0; i < 50000; i++)
                {
                    Thread.Sleep(10);
                    int id = Convert.ToInt32(DateTime.Now.Ticks % 1000000000);

                    _context.Tickets.Add(new Ticket { Id = Convert.ToInt32(id) });
                    await _context.SaveChangesAsync();
                }
               
            }

         
        }

    }
}

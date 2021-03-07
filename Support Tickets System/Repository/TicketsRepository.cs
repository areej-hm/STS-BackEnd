using Support_Tickets_System.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Support_Tickets_System.Entities;
using Microsoft.EntityFrameworkCore;



namespace Support_Tickets_System.Repository
{
    public class TicketsRepository : ITicktesRepository
    {
        private readonly Context _context;

        public TicketsRepository(Context context)
        {
            _context = context;
        }

        public async Task<List<Tickets>> GetAllTickets()
        {
            var tickets = await _context.Tickets.Include(e=>e.Client).ToListAsync();
            return tickets;
        }
        public async Task<List<Tickets>> GetAllTicketsforClientId(int clientId)
        {
            var tickets = await _context.Tickets.Include(e => e.Client).Where(e=>e.ClientId== clientId).ToListAsync();
            return tickets;
        }
        
        public async Task<Tickets> GetTicketByID(int id)
        {
            var ticket = await _context.Tickets.Where(e => e.ID == id)
                                            .FirstOrDefaultAsync();
            return ticket;

        }

        public async Task<Tickets> Add(Tickets ticket)
        {
            _context.Add(ticket);
            await _context.SaveChangesAsync();
            return ticket;
        }

        public async Task<bool> Update(Tickets ticket)
        {
            _context.Update(ticket);
            var success = await _context.SaveChangesAsync();
            if (success == 0)
                return false;
            return true;
        }
        public async Task<bool> DeleteByID(int id)
        {
            var ticket = await GetTicketByID(id);
            _context.Remove(ticket);
            var success = await _context.SaveChangesAsync();
            if (success == 0)
                return false;
            return true;
        }
    }
}

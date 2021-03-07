using Support_Tickets_System.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Support_Tickets_System.IRepository
{
    public interface ITicktesRepository
    {
        Task<List<Tickets>> GetAllTickets();
        Task<List<Tickets>> GetAllTicketsforClientId(int clientId);
        Task<Tickets> GetTicketByID(int id);
        Task<Tickets> Add(Tickets ticket);
        Task<bool> Update(Tickets ticket);
        Task<bool> DeleteByID(int id);
    }
}

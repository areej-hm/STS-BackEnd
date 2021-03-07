using Support_Tickets_System.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Support_Tickets_System.Models;

namespace Support_Tickets_System.IRepository
{
    public interface IClientRepository
    {
        Task<Client> Login(string username, string password);
        Task<List<Client>> GetAllClients();
        Task<Client> GetClientByID(int id);
        Task<Client> Add(Client Client);
        Task<bool> Update(Client Client);
        Task<bool> DeleteByID(int id);
    }
}

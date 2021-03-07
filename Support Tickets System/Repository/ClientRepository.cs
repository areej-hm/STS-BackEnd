using Support_Tickets_System.Entities;
using Support_Tickets_System.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace Support_Tickets_System.Repository
{
    public class ClientRepository : IClientRepository
    {
        private readonly Context _context;

        public ClientRepository(Context context)
        {
            _context = context;
        }
        
        public async Task<Client> Login(string username, string password)
        {
            var client = await _context.Clients.Where(e=> e.UserName == username && e.Password== password).FirstOrDefaultAsync();
            if (client == null)
            {
                throw new Exception("Password or username you've entered is incorrect");
            }
            return client;
        }
        public async Task<List<Client>> GetAllClients()
        {
            var clients = await _context.Clients.ToListAsync();
            return clients;
        }

        public async Task<Client> GetClientByID(int id)
        {
            var client = await _context.Clients.Where(e => e.ID == id)
                                            .FirstOrDefaultAsync();
            return client;

        }

        public async Task<Client> Add(Client client)
        {
            _context.Add(client);
            await _context.SaveChangesAsync();
            return client;
        }

        public async Task<bool> Update(Client client)
        {
            _context.Update(client);
            var success = await _context.SaveChangesAsync();
            if (success == 0)
                return false;
            return true;
        }
        public async Task<bool> DeleteByID(int id)
        {
            var client = await GetClientByID(id);
            _context.Remove(client);
            var success = await _context.SaveChangesAsync();
            if (success == 0)
                return false;
            return true;
        }
    }
}

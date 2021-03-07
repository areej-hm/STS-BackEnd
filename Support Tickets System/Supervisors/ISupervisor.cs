using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Support_Tickets_System.Models;




namespace Support_Tickets_System.Supervisors
{
    public interface ISupervisor
    {
        #region Clients

        Task<ClientModel> Login(LoginModel loginModel);

        Task<List<ClientModel>> GetAllClients();

        Task<ClientModel> GetClientByID(int id);

        Task<ClientModel> AddClient(ClientModel ClientModel);

        Task<ClientModel> Registration(ClientModel ClientModel);

        Task<bool> UpdateClient(ClientModel ClientModel);

        Task<bool> DeleteClientById(int id);
        #endregion

        #region Tickets

        Task<List<TicketsModel>> GetAllTickets();

        Task<List<TicketsModel>> GetAllTicketsforClientId(int clientId);

        Task<TicketsModel> GetTicketById(int id);

        Task<TicketsModel> AddTicket(TicketsModel ticket);

        Task<bool> UpdateTicket(TicketsModel ticket);

        Task<bool> DeleteTicketById(int id);
        #endregion
    }
}

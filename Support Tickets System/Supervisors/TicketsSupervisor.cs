using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Support_Tickets_System.Entities;
using Support_Tickets_System.Models;

namespace Support_Tickets_System.Supervisors
{
    public partial class Supervisor
    {
        public async Task<List<TicketsModel>> GetAllTickets()
        {
            var tickets = await _ITicketsRepository.GetAllTickets();
            return _mapper.Map<List<TicketsModel>>(tickets);
        }
        public async Task<List<TicketsModel>> GetAllTicketsforClientId(int clientId)
        {
            var tickets = await _ITicketsRepository.GetAllTicketsforClientId(clientId);
            return _mapper.Map<List<TicketsModel>>(tickets);
        }
        
        public async Task<TicketsModel> GetTicketById(int id)
        {

            var ticket = await _ITicketsRepository.GetTicketByID(id);
            return _mapper.Map<TicketsModel>(ticket);
        }

        public async Task<TicketsModel> AddTicket(TicketsModel ticket)
        {
            var ticketsEntity = _mapper.Map<Tickets>(ticket);
            return _mapper.Map<TicketsModel>(await _ITicketsRepository.Add(ticketsEntity));
        }
        public async Task<bool> UpdateTicket(TicketsModel ticket)
        {
            var ticketEntity = _mapper.Map<Tickets>(ticket);
            ticketEntity.CreationDate = DateTime.Now;
            return await _ITicketsRepository.Update(ticketEntity);
        }

        public async Task<bool> DeleteTicketById(int id)
        {
            try
            {
                await _ITicketsRepository.DeleteByID(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Support_Tickets_System.Models;
using Support_Tickets_System.Supervisors;

namespace Support_Tickets_System.Controllers
{
    [Route("api/Tickets")]
    [ApiController]
    public class TicktesController: Controller
    {
        private readonly ISupervisor _ISupervisor;
        public TicktesController(ISupervisor ISupervisor)
        {
            _ISupervisor = ISupervisor;
        }

        [HttpGet("GetAllTickets")]
        [EnableCors("TheCodeBuzzPolicy")]
        public async Task<IActionResult> GetAllTickets()
        {
            var result = await _ISupervisor.GetAllTickets();
            return Ok(result);
        }

        [HttpGet("GetAllTicketsforClientId/{clientId}")]
        [EnableCors("TheCodeBuzzPolicy")]
        public async Task<IActionResult> GetAllTicketsforClientId(int clientId)
        {
            var result = await _ISupervisor.GetAllTicketsforClientId(clientId);
            return Ok(result);
        }

        [HttpGet("GetTicketById/{id}")]
        [EnableCors("TheCodeBuzzPolicy")]
        public async Task<IActionResult> GetTicketById(int id)
        {
            var result = await _ISupervisor.GetTicketById(id);
            return Ok(result);
        }

        [HttpPost("AddTicket")]
        [EnableCors("TheCodeBuzzPolicy")]
        public async Task<IActionResult> AddTicket([FromBody]TicketsModel ticket)
        {
            try
            {
                var result = await _ISupervisor.AddTicket(ticket);
                return Ok(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPut("UpdateTicket")]
        [EnableCors("TheCodeBuzzPolicy")]
        public async Task<IActionResult> UpdateTicket([FromBody] TicketsModel ticket)
        {
            try
            {
                var result = await _ISupervisor.UpdateTicket(ticket);
                return Ok(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete("DeleteTicketById/{id}")]
        [EnableCors("TheCodeBuzzPolicy")]
        public async Task<IActionResult> DeleteTicketById(int id)
        {
            var result = await _ISupervisor.DeleteTicketById(id);
            return Ok(result);
        }
    }
}

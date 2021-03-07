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
    [Route("api/Client")]
    [ApiController]
    public class ClientController :Controller
    {
        private readonly ISupervisor _ISupervisor;
        public ClientController(ISupervisor ISupervisor)
        {
            _ISupervisor = ISupervisor;
        }

        [HttpGet("GetAllClients")]
        [EnableCors("TheCodeBuzzPolicy")]
        public async Task<IActionResult> GetAllClients()
        {
            var result = await _ISupervisor.GetAllClients();
            return Ok(result);
        }

        [HttpGet("GetClientById/{id}")]
        [EnableCors("TheCodeBuzzPolicy")]
        public async Task<IActionResult> GetClientById(int id)
        {
            var result = await _ISupervisor.GetClientByID(id);
            return Ok(result);
        }

        [HttpPost("Login")]
        [EnableCors("TheCodeBuzzPolicy")]
        public async Task<IActionResult> Login([FromBody]LoginModel input)
        {
            try
            {
                var result = await _ISupervisor.Login(input);
                return Ok(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        [HttpPost("Registration")]
        [EnableCors("TheCodeBuzzPolicy")]
        public async Task<IActionResult> Registration([FromBody]ClientModel Client)
        {
            try
            {
                var result = await _ISupervisor.Registration(Client);
                return Ok(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost("AddClient")]
        [EnableCors("TheCodeBuzzPolicy")]
        public async Task<IActionResult> AddClient([FromBody]ClientModel Client)
        {
            try
            {
                var result = await _ISupervisor.AddClient(Client);
                return Ok(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPut("UpdateClient")]
        [EnableCors("TheCodeBuzzPolicy")]
        public async Task<IActionResult> UpdateClient([FromBody] ClientModel Client)
        {
            try
            {
                var result = await _ISupervisor.UpdateClient(Client);
                return Ok(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete("DeleteClientById/{id}")]
        [EnableCors("TheCodeBuzzPolicy")]
        public async Task<IActionResult> DeleteClientById(int id)
        {
            var result = await _ISupervisor.DeleteClientById(id);
            return Ok(result);
        }
    }
}

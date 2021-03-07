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
        
        public async Task<ClientModel> Login(LoginModel loginModel)
        {
            try
            {
                var clients = await _IClientRepository.Login(loginModel.UserName, loginModel.Password);
                return _mapper.Map<ClientModel>(clients);
            }
            catch (Exception ex)
            {

                throw ex;
            }
         
        }
        public async Task<List<ClientModel>> GetAllClients()
        {
            var clients = await _IClientRepository.GetAllClients();
            return _mapper.Map<List<ClientModel>>(clients);
        }
        public async Task<ClientModel> GetClientByID(int id)
        {

            var Employee = await _IClientRepository.GetClientByID(id);
            return _mapper.Map<ClientModel>(Employee);
        }
        
        public async Task<ClientModel> Registration(ClientModel input)
        {
            var clientEntity = _mapper.Map<Client>(input);
            return _mapper.Map<ClientModel>(await _IClientRepository.Add(clientEntity));
        }
        public async Task<ClientModel> AddClient(ClientModel input)
        {
            var clientEntity = _mapper.Map<Client>(input);
            return _mapper.Map<ClientModel>(await _IClientRepository.Add(clientEntity));
        }
        public async Task<bool> UpdateClient(ClientModel input)
        {
            var clientEntity = _mapper.Map<Client>(input);
            clientEntity.CreationDate = DateTime.Now;
            return await _IClientRepository.Update(clientEntity);
        }

        public async Task<bool> DeleteClientById(int id)
        {
            try
            {
                await _IClientRepository.DeleteByID(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return true;
        }
    }
}

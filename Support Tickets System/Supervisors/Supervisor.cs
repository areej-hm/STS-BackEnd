using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Support_Tickets_System.IRepository;
using AutoMapper;

namespace Support_Tickets_System.Supervisors
{
    public partial class Supervisor :ISupervisor
    {
        private IClientRepository _IClientRepository;
        private ITicktesRepository _ITicketsRepository;

        private readonly IMapper _mapper;

        public Supervisor(IClientRepository IClientRepository, ITicktesRepository ITicketsRepository, IMapper mapper)
        {
            _IClientRepository = IClientRepository;
            _ITicketsRepository = ITicketsRepository;
            _mapper = mapper;
        }
    }
}

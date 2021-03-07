using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Support_Tickets_System.Entities;
using Support_Tickets_System.Models;

namespace Support_Tickets_System.Mapper
{
    public class AutoMapping:Profile
    {
        public AutoMapping()
        {
            CreateMap<Client, ClientModel>();
            CreateMap<ClientModel, Client> ();

            CreateMap<Tickets, TicketsModel>();
            CreateMap<TicketsModel,Tickets> ();

        }
    }
}

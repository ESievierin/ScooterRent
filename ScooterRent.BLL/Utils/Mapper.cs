using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ScooterRent.BLL.DTO;

using ScooterRent.DAL.Entities;

namespace ScooterRent.BLL.Utils
{
    internal class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<CustomerDTO, Customer>().ReverseMap();
            CreateMap<TarifDTO, Tarif>().ReverseMap();
            CreateMap<RentDTO, Rent>().ReverseMap();
            CreateMap<ScooterDTO, Scooter>().ReverseMap();
        }
    }
}

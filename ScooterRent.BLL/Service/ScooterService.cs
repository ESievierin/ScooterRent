using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScooterRent.DAL.Entities;
using ScooterRent.BLL.DTO;
using ScooterRent.DAL.Interfaces;
using ScooterRent.BLL.Interfaces;
using AutoMapper;

namespace ScooterRent.BLL.Service
{
     public  class ScooterService : IScooterService
    {
        private IWorkUnit Database { get; set; }
        private IMapper mapperScooter;
        public ScooterService(IWorkUnit database)
        {
            Database = database;
            mapperScooter = new MapperConfiguration(cfg =>
                cfg.CreateMap<Scooter, ScooterDTO>().ReverseMap())
                .CreateMapper();
        }
        public IEnumerable<ScooterDTO> GetAll()
        {
            return mapperScooter.Map<IEnumerable<Scooter>, List<ScooterDTO>>(Database.Scooter.GetAll());
        }
        public ScooterDTO Get(int id)
        {
            return mapperScooter.Map<Scooter, ScooterDTO>(Database.Scooter.Get(id));
        }
        public void Create(ScooterDTO item)
        {
            Database.Scooter.Create(mapperScooter.Map<ScooterDTO,Scooter>(item));
            Database.Save();
        }
        public void Delete(int id)
        {
            var data = Database.Scooter.Get(id);
            if (data != null)
            {
                Database.Scooter.Delete(id);
                Database.Save();
            }
        }

    }
}

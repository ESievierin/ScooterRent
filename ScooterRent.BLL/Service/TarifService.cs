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
    public  class TarifService : ITarifService
    {
        private IMapper mapperTarif;
        private IWorkUnit Database;
        public TarifService(IWorkUnit database)
        {
            Database = database;
            mapperTarif = new MapperConfiguration(cfg => cfg.CreateMap<Tarif, TarifDTO>().ReverseMap()).CreateMapper();
        }
        public IEnumerable<TarifDTO> GetAll()
        {
            return mapperTarif.Map<IEnumerable<Tarif>, List<TarifDTO>>(Database.Tarif.GetAll());
        }
        public TarifDTO Get(int id)
        {
            return mapperTarif.Map<Tarif, TarifDTO>(Database.Tarif.Get(id));
        }
        public void Create(TarifDTO item) 
        {
            Database.Tarif.Create(mapperTarif.Map<TarifDTO, Tarif>(item));
            Database.Save();
        }
        public void Delete(int id)
        {
            var data = Database.Tarif.Get(id);
            if(data != null)
            {
                Database.Tarif.Delete(id);
                Database.Save();
            }
        }
        public void Update(TarifDTO newitem,int id)
        {
            Database.Tarif.Update(mapperTarif.Map<TarifDTO, Tarif>(newitem),id);
            Database.Save();
        }
    }
}

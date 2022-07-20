using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScooterRent.DAL.Entities;
using ScooterRent.BLL.DTO;
using ScooterRent.DAL.Interfaces;
using ScooterRent.BLL.Interfaces;
using ScooterRent.BLL.Service;
using AutoMapper;


namespace ScooterRent.BLL.Service
{
    public class RentServise : IRentService
    {

        private IMapper mapperRent;

        private IWorkUnit Database;

        public RentServise(IWorkUnit database)
        {
            Database = database;
            mapperRent = new MapperConfiguration(cfg => cfg.CreateMap<Rent, RentDTO>().ReverseMap()).CreateMapper();
        }

        public IEnumerable<RentDTO> GetAll()
        {
            return mapperRent.Map<IEnumerable<Rent>, List<RentDTO>>(Database.Rent.GetAll());
        } 

        public RentDTO Get(int id)
        {
            return mapperRent.Map<Rent, RentDTO>(Database.Rent.Get(id));
        }

        public decimal GetPriceForRent(int id)
        {
            RentDTO rent = mapperRent.Map<Rent, RentDTO>(Database.Rent.Get(id));

            decimal tarifPriceForMin = Database.Tarif.Get(rent.TarifId).CostPerMin;
            int rentTime = rent.EndTime.Minute - rent.StartTime.Minute;
            decimal priceForRent = tarifPriceForMin * rentTime;

            return priceForRent;
        }

        public void StartRent(int customerid, int scooterid, int tarifid)
        {
            RentDTO rent = new RentDTO(customerid,scooterid,tarifid,DateTime.Now);
            Database.Rent.Create(mapperRent.Map<RentDTO, Rent>(rent));
            Database.Save();
        }
        public void EndRent(int id)
        {
            RentDTO rent = mapperRent.Map<Rent, RentDTO>(Database.Rent.Get(id));
            rent.EndTime = DateTime.Now;
            Database.Rent.Update(mapperRent.Map<RentDTO, Rent>(rent), id);
            Database.Save();
        }
        public void Delete(int id)
        {
            var data = Database.Rent.Get(id);
            if(data != null)
            {
                Database.Rent.Delete(id);
                Database.Save();
            }
        }
       

    }
}

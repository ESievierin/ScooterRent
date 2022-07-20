using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScooterRent.BLL.DTO;

namespace ScooterRent.BLL.Interfaces
{
     public interface IRentService
    {
        IEnumerable<RentDTO> GetAll();
        RentDTO Get(int id);
        
        void Delete(int id); 
        public decimal GetPriceForRent(int id);
        public void StartRent(int customerid, int scooterid, int tarifid);
        public void EndRent(int id);
    }
}

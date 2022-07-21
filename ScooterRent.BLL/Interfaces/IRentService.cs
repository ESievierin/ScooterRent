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

        decimal GetPriceForRent(int id);

        int GetLastRentIdByCustomer(CustomerDTO customer);

        void StartRent(int customerid, int scooterid, int tarifid);

        void EndRent(int id);
    }
}

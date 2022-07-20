using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScooterRent.BLL.DTO;

namespace ScooterRent.BLL.Interfaces
{
     public interface ITarifService
    {
        IEnumerable<TarifDTO> GetAll();
        TarifDTO Get(int id);
        void Create(TarifDTO item);
        void Delete(int id);
        void Update(TarifDTO newTarif, int id);
    }
}

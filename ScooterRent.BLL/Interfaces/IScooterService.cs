using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScooterRent.BLL.DTO;

namespace ScooterRent.BLL.Interfaces
{
    public interface IScooterService
    {
        IEnumerable<ScooterDTO> GetAll();
        ScooterDTO Get(int id);
        void Create(ScooterDTO item);
        void Delete(int id);
    }
}

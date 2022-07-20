using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScooterRent.BLL.DTO;

namespace ScooterRent.BLL.Interfaces
{
    public interface ICustomerService
    {
        IEnumerable<CustomerDTO> GetAll();
        CustomerDTO Get(int id);
        CustomerDTO GetByNumber(string phonenubmer);

        bool Register(int age, string phonenumber);
        void Create(CustomerDTO item);
        void Delete(int id);
    }
}

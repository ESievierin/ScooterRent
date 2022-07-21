using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScooterRent.BLL.DTO
{
    public class CustomerDTO
    {
        public int Id { get;private set; }
       
        public string PhoneNumber { get; set; }

        public int Age { get; set; }
        public CustomerDTO(string phoneNumber,int age)
        {
            PhoneNumber= phoneNumber;
            Age = age;
        }

    }
}

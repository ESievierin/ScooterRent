using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScooterRent.BLL.DTO
{
    public class ScooterDTO
    {
        public int Id { get; private set; }
        
        public string Make { get; set; }
        public ScooterDTO(string make)
        {
            Make = make;
        }








    }
}

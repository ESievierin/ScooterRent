using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScooterRent.BLL.DTO
{
    public class TarifDTO
    {
        public int Id { get; private set; }

        public decimal CostPerMin { get; set; }
        
        public string Name { get; set; }
        public TarifDTO(string name,decimal costPerMin)
        {
            Name = name;
            CostPerMin = costPerMin;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScooterRent.Entities
{
    internal class Scooter
    {
        public int Id { get; set; }
        [Required]
        public string Make { get; set; }
  

 
        


       

        public virtual ICollection<Rent> Rents { get; set; }
    }
}

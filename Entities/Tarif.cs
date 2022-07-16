using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScooterRent.Entities
{
    internal class Tarif
    {
        public int Id { get; set; }

        public decimal CostPerKm { get; set; }

        public decimal CostPerMin { get; set; }
        [Required]
        public string Name { get; set; }

        public virtual ICollection<Rent> Rents { get; set; }
    }
}

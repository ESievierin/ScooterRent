using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScooterRent.Entities
{
    internal class Rent
    {
        public int Id { get; set; }

        public int TarifId { get; set; }

        public int CustomerId { get; set; }

        public int ScooterId { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }


        public virtual Tarif Tarif { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Scooter Scooter { get; set; }
    }
}

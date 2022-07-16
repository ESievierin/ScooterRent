using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ScooterRent.Entities
{
    internal class Customer
    {
      public int Id { get; set; }
      [Required]
      public string PhoneNumber { get; set; }

      public int Age { get; set; }

      public virtual ICollection<Rent> Rents { get; set; }
    }
}

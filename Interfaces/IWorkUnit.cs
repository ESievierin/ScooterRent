using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScooterRent.Repositories;
using ScooterRent.Entities;

namespace ScooterRent.Interfaces
{
    internal interface IWorkUnit
    {
        IRepository<Customer> Customers { get; set; }

        IRepository<Parking> Parking { get; set; }

        IRepository<Rent> Rent { get; set; }

        IRepository<Scooter> Scooter { get; set; }

        IRepository<Tarif> Tarif { get; set; }

        void Save();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScooterRent.EF;
using ScooterRent.Entities;
using ScooterRent.Interfaces;
using ScooterRent.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace ScooterRent.Repositories
{
    internal class WorkUnit
    {
        private ScooterRentContext db;
        private CustomerRepository CustomerRepository;
        private RentRepository RentRepository;
        private ScooterRepository ScooterRepository;
        private TarifRepository TarifRepository;
        
        public WorkUnit()
        {
            db = new ScooterRentContext();
        }
        public CustomerRepository Customers
        {
            get
            {
                if(CustomerRepository == null)
                    CustomerRepository = new CustomerRepository(db);
               return CustomerRepository;
            }
             
        }
        public RentRepository Rents
        {
            get
            {
                if (RentRepository == null)
                    RentRepository = new RentRepository(db);
                return RentRepository;
            }

        }
        public ScooterRepository Scooters
        {
            get
            {
                if (ScooterRepository == null)
                    ScooterRepository = new ScooterRepository(db);
                return ScooterRepository;
            }

        }
        public TarifRepository Tarifs
        {
            get
            {
                if (TarifRepository == null)
                    TarifRepository = new TarifRepository(db);
                return TarifRepository;
            }

        }
        public void Save()
        {
            db.SaveChanges();
        }

    }
}

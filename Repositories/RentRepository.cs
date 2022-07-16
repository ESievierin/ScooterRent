using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScooterRent.EF;
using ScooterRent.Interfaces;
using ScooterRent.Entities;
using Microsoft.EntityFrameworkCore;

namespace ScooterRent.Repositories
{
    internal class RentRepository : IRepository<Rent>
    {
        private ScooterRentContext db;
        public RentRepository(ScooterRentContext db)
        {
            this.db = db;
        }
        public IEnumerable<Rent> GetAll()
        {
            return db.Rents;
        }
        public void Delete(int Id)
        {
            Rent rent = db.Rents.Find(Id);
            if (rent != null)
                db.Rents.Remove(rent);
        }
        public Rent Get(int Id)
        {
            return db.Rents.Find(Id);
        }
        public void Create(Rent rent)
        {
            db.Rents.Add(rent);
        }
        public void Update(Rent newitem, int id)
        {
            Rent rent = Get(id);
            if (rent != null)
            {
                rent.Id = newitem.Id;
                rent.CustomerId = newitem.CustomerId;
                rent.TarifId = newitem.TarifId;
                rent.ScooterId = newitem.ScooterId;
                rent.StartTime = newitem.StartTime;
                rent.EndTime = newitem.EndTime;


            }
            db.Entry(rent).State = EntityState.Modified;

        }
    }
}

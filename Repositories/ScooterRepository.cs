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
    internal class ScooterRepository : IRepository<Scooter>
    {

        private ScooterRentContext db;
        public ScooterRepository(ScooterRentContext db)
        {
            this.db = db;
        }
        public IEnumerable<Scooter> GetAll()
        {
            return db.Scooters;
        }
        public void Delete(int Id)
        {
            Scooter scooter = db.Scooters.Find(Id);
            if (scooter != null)
                db.Scooters.Remove(scooter);
        }
        public Scooter Get(int Id)
        {
            return db.Scooters.Find(Id);
        }
        public void Create(Scooter scooter)
        {
            db.Scooters.Add(scooter);
        }
        public void Update(Scooter newitem, int id)
        {
            Scooter scooter = Get(id);
            if (scooter != null)
            {
                scooter.Id = newitem.Id;
                scooter.Make = newitem.Make;
                scooter.Energy= newitem.Energy;
                scooter.ParkingId = newitem.ParkingId;
              

            }
            db.Entry(scooter).State = EntityState.Modified;

        }
    }
}

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
    internal class TarifRepository : IRepository<Tarif>
    {
        private ScooterRentContext db;
        public TarifRepository(ScooterRentContext db)
        {
            this.db = db;
        }
        public IEnumerable<Tarif> GetAll()
        {
            return db.Tarifs;
        }
        public void Delete(int Id)
        {
           Tarif tarif = db.Tarifs.Find(Id);
            if (tarif != null)
                db.Tarifs.Remove(tarif);
        }
        public Tarif Get(int Id)
        {
            return db.Tarifs.Find(Id);
        }
        public void Create(Tarif tarif)
        {
            db.Tarifs.Add(tarif);
        }
        public void Update(Tarif newitem, int id)
        {
            Tarif tarif = Get(id);
            if (tarif != null)
            {
                tarif.Id = newitem.Id;
                tarif.CostPerMin = newitem.CostPerMin;
                tarif.CostPerKm = newitem.CostPerKm;
                tarif.Name = newitem.Name;


            }
            db.Entry(tarif).State = EntityState.Modified;

        }
    }
}

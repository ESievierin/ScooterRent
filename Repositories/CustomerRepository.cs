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
    internal class CustomerRepository : IRepository<Customer>
    {
        
        private ScooterRentContext db;
        public CustomerRepository(ScooterRentContext db)
        {
            this.db = db;
        }
        public IEnumerable<Customer> GetAll()
        {
            return db.Customers;
        }
        public void Delete(int Id)
        {
            Customer customer = db.Customers?.Find(Id);
            if(customer != null)
                db.Customers.Remove(customer);
        }
        public Customer Get(int Id)
        {
            return db.Customers.Find(Id);
        }
        public void Create(Customer customer)
        {
            db.Customers.Add(customer);
        }
        public void Update(Customer newitem, int id)
        {
            Customer customer = Get(id);
            if(customer != null)
            {
                customer.Id = newitem.Id;
                customer.Age = newitem.Age;
                customer.PhoneNumber = newitem.PhoneNumber;
                
            }
            db.Entry(customer).State = EntityState.Modified;
            
        }


    }
}

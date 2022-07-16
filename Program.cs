using Microsoft.EntityFrameworkCore;
using ScooterRent.EF;
using ScooterRent.Repositories;
using ScooterRent.Entities;
using Microsoft.EntityFrameworkCore.SqlServer;


    WorkUnit workUnit = new WorkUnit();
    Customer customer = new Customer();
    customer.Age = 13;
    customer.PhoneNumber = "+380";
    workUnit.Customers.Create(customer);
    workUnit.Save();
    Console.WriteLine(workUnit.Customers.Get(1).Age);
    Console.WriteLine("Lol");

    
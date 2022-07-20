using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using System.Threading.Tasks;
using ScooterRent.DAL.Entities;
using ScooterRent.BLL.DTO;
using ScooterRent.DAL.Interfaces;
using ScooterRent.BLL.Interfaces;


namespace ScooterRent.BLL.Service
{
    
    public class CustomerService : ICustomerService
    {
      private IMapper mapperCustomer;
       
        private IWorkUnit Database { get; set; }
        public CustomerService(IWorkUnit database)
        {
            Database = database;
            mapperCustomer = new MapperConfiguration(cfg => cfg.CreateMap<Customer,CustomerDTO>().ReverseMap()).CreateMapper();
            
        }
        public IEnumerable<CustomerDTO> GetAll()
        {
            return mapperCustomer.Map<IEnumerable<Customer>, List<CustomerDTO>>(Database.Customers.GetAll());
        }
        public CustomerDTO Get(int id)
        {
            return mapperCustomer.Map<Customer,CustomerDTO>(Database.Customers.Get(id));
        }
        public void Create(CustomerDTO item)
        {
            Database.Customers.Create(mapperCustomer.Map<CustomerDTO, Customer>(item));
            Database.Save();
        }
        public void Delete(int id)
        {
            var data = Database.Customers.Get(id);
            if (data != null)
            {
                Database.Customers.Delete(id);
                Database.Save();
            }

        }
        public CustomerDTO GetByNumber(string phonenumber)
        {
            var user = Database.Customers.GetAll().Where(customer => customer.PhoneNumber == phonenumber).FirstOrDefault();
            if (user != null)
            {
                return mapperCustomer.Map<Customer, CustomerDTO>(user);
            }
            else
            {
                return null; 
            }
        }
        public bool Register(int age,string phonenumber)
        {
            CustomerDTO newCustomer = new CustomerDTO(phonenumber, age);
           
            if(Database.Customers.GetAll().Where(Customer => Customer.PhoneNumber == phonenumber).FirstOrDefault() == null)
            {
                Create(newCustomer);
                return true;
            }
            else
            {
                return false;
            }
         
            
        }
    }
}

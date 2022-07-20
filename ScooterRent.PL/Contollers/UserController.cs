using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScooterRent.BLL.Service;
using ScooterRent.BLL.Interfaces;
using ScooterRent.BLL.DTO;


namespace ScooterRent.PL.Contollers
{
      public class UserController
    {
         public CustomerDTO ActiveCustomer { get; set; }
         private ICustomerService customerService { get; set; }
         public UserController(ICustomerService customerservice)
         {
            customerService = customerservice;
         }




        public void SingUp()
       {
            Console.Clear();
            Console.WriteLine("Sing Up\n");
            Console.WriteLine("Input you phone number :");
            string phoneNumber = Console.ReadLine();
            Console.WriteLine("Input you age  :");
            int Age = Convert.ToInt32(Console.ReadLine());
            if (customerService.Register(Age,phoneNumber))
            {
                SingIn();
            }
            else
            {
                Console.WriteLine("This number arleady register,do you want sign in?\n1-No,i want try again\n2-Yes");
            }
               
            
       }
          public void SingIn()
      {
            Console.Clear();
            Console.WriteLine("Sing In\n");
            Console.WriteLine("Input you phone number : ");
            string phonenumber = Console.ReadLine();
            var customer = customerService.GetByNumber(phonenumber);
            if(customer != null)
            {
                ActiveCustomer = customer;
                
            }
            else
            {
                Console.WriteLine("No user found");
                Console.WriteLine("Do you want to register?\n1-Yes\n2-No");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        SingUp();

                        break;
                    case 2:
                        SingIn();
                        break;

                }
            }
               
          
            

        }
        public void ShowUserInfo()
        {
            Console.Clear();
            Console.WriteLine("Phone number : {0}",ActiveCustomer.PhoneNumber);
            Console.WriteLine("Age : {0}", ActiveCustomer.Age);
        }
          public void LogoutFromAccount()
        {
            ActiveCustomer = null;
            
        }
      
    }
}
    


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
     public class HomeController
     {
        private RentContoller rentContoller;

        private UserController userController;

        public HomeController(
            RentContoller rentcontoller, 
            UserController usercontroller)
        {
          rentContoller = rentcontoller;       
          userController = usercontroller;
        }
        

       
       public void Start()
       {
            Console.Clear();
            Console.WriteLine("Choose action :");
            Console.WriteLine("1-Sing In");
            Console.WriteLine("2-Sing Up");
           
            {
                switch (Console.ReadLine())
                {
                    case "1":
                        userController.SingIn();
                        OpenMainMenu();

                        break;
                    case "2":
                        userController.SingUp();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Incorrect Input,Try again");
                        Console.WriteLine("Press enter to go back");
                        Console.ReadLine();
                        Start();
                        break;


                }
            }
           
        }

        public void OpenMainMenu()
        {
            Console.Clear();
            Console.WriteLine("1-Data about account");
            Console.WriteLine("2-Rent scooter");
            Console.WriteLine("3-Logout from account");

            switch (Console.ReadLine())
            {
                case "1":
                    userController.ShowUserInfo();
                    Console.WriteLine("\n if you want back to menu press enter");
                    Console.ReadLine();
                    OpenMainMenu();
                    break;
                case "2":
                    rentContoller.RentScooter();
                    OpenRentMenu();
                    break;
                case "3":
                    userController.LogoutFromAccount();
                    Start();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Incorrect Input,Try again");
                    Console.WriteLine("Press enter to go back");
                    Console.ReadLine();
                    OpenMainMenu();
                    break;

            }
        }
        public void OpenRentMenu()
        {
            Console.Clear();
            Console.WriteLine("1- Stop rent");

            if(Console.ReadLine() == "1")
            {
                rentContoller.EndRent();
                OpenMainMenu();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Incorrect Input,Try again");
                Console.WriteLine("Press enter to go back");
                Console.ReadLine();
                OpenRentMenu();
            }

        }
    }
}

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
    public class RentContoller
    {
        
        private TarifController tarifController;
        private ScooterController scooterController;
        private UserController userController;  
        private IRentService rentService;
        private ITarifService tarifService;
        private IScooterService scooterService;
        private RentDTO CurrentRent;
        
        public RentContoller(
            IRentService rentservice,
            
            TarifController tarifcontroller,
            ScooterController scootercontroller,
            UserController usercontroller)
        {

            rentService = rentservice;         
            tarifController =  tarifcontroller;
            scooterController = scootercontroller;
            userController = usercontroller;
        }
        public void RentScooter()
        {
            Console.Clear();
            int scooterid = 0; ;
            int tarifid = 0;
            Console.WriteLine("Choose Scooter\n");
            scooterController.ShowAll();
            try
            {
                 scooterid = int.Parse(Console.ReadLine());
            }
            catch(FormatException)
            {
                Console.Clear();
                Console.WriteLine("Incorrect Input,Try again");
                Console.WriteLine("Press enter to go back");
                Console.ReadLine();
                RentScooter();
            }
            
            Console.Clear();
            Console.WriteLine("Choose Tarif\n");
            tarifController.ShowAll();
            try
            {
                 tarifid = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.Clear();
                Console.WriteLine("Incorrect Input,Try again");
                Console.WriteLine("Press enter to go in main menu");
                Console.ReadLine();
                RentScooter();
            }
            
            rentService.StartRent(userController.ActiveCustomer.Id, scooterid, tarifid);
            
        }
        public void EndRent()
        {
            Console.Clear();
            int rentid = rentService.GetLastRentIdByCustomer(userController.ActiveCustomer);
            rentService.EndRent(rentid);
            Console.WriteLine("Price for rent :{0}",rentService.GetPriceForRent(rentid));
            Console.WriteLine("If you want open main menu press enter");
            Console.ReadLine();
            
            
        }
    }
}

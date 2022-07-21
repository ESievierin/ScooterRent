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
     public  class ScooterController
    {
        private IScooterService scooterService
        public ScooterController(IScooterService scooterservice)
        {
            scooterService = scooterservice;
        }
        public void ShowAll()
        {
            var scootersDTO = scooterService.GetAll();
            foreach (ScooterDTO scooter in scootersDTO)
            {
                Console.WriteLine("{0} - Make : {1}", scooter.Id, scooter.Make);
            }
        }
    }
}

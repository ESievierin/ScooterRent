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
        private IScooterService scooterService { get; set; }
        public ScooterController(IScooterService scooterservice)
        {
            scooterService = scooterservice;
        }
        public void ShowAll()
        {
            var scooterDTOs = scooterService.GetAll();
            foreach (ScooterDTO scd in scooterDTOs)
            {
                Console.WriteLine("{0} - Make : {1}", scd.Id, scd.Make);
            }
        }
    }
}

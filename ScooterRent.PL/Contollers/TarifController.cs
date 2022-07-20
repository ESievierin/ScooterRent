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
    public class TarifController
    {
        private ITarifService tarifService { get; set; }
        public TarifController(ITarifService tarifservice)
        {
            tarifService = tarifservice;
        }
        public void ShowAll()
        {
            var tarifDTOs = tarifService.GetAll();
            foreach(TarifDTO trd in tarifDTOs)
            {
                Console.WriteLine("{0} - Name : {1}, Price for minute : {2}",trd.Id,trd.Name,trd.CostPerMin);
            }
        }
    }
}

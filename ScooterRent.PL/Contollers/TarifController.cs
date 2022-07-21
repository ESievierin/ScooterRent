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
        private ITarifService tarifService 
        public TarifController(ITarifService tarifservice)
        {
            tarifService = tarifservice;
        }
        public void ShowAll()
        {
            var tarifsDTO = tarifService.GetAll();
            foreach(TarifDTO tarif in tarifsDTO)
            {
                Console.WriteLine("{0} - Name : {1}, Price for minute : {2}", tarif.Id, tarif.Name, tarif.CostPerMin);
            }
        }
    }
}

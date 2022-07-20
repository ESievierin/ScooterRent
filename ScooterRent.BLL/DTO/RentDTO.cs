using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScooterRent.BLL.DTO
{
    public  class RentDTO
    {
        public int ID { get; set; }
        public int TarifId { get; private set; }

        public int CustomerId { get; private  set; }

        public int ScooterId { get; private set; }

        public DateTime StartTime { get;private set; }

        public DateTime EndTime { get; set; }
        public RentDTO(int tarifId,int customerId,int scooterId,DateTime startTime)
        {
            TarifId = tarifId;
            CustomerId = customerId;
            ScooterId = scooterId;
            StartTime = startTime;

        }
    }
}

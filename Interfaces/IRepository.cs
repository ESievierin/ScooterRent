using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScooterRent.Interfaces
{
    internal interface IRepository<T>       
    {
        IEnumerable<T> GetAll(); 

        T Get(int id);

        void Delete(int id);

        void Create(T entity);

        void Update(T entity, int id );



    }
}

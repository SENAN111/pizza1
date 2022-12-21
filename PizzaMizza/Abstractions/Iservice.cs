using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaMizza.Abstractions
{
    internal interface Iservice<T>
    {
        void Add(T model);
        void Delete(int id );
        void Update(T model);
        List<T> GetAll();
    }
}

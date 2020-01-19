using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorys_FactoryMethod
{
    public abstract class PizzaStore
    {
        public abstract IPizza CreatPizza(string type);
        public IPizza OrderPizze(string type)
        {
            IPizza pizza = CreatPizza(type);
            pizza.Prepare();
            pizza.Cook();
            return pizza;
        }
    }
}

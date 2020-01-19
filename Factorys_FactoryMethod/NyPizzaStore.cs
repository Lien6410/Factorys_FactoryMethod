using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorys_FactoryMethod
{
    public class NyPizzaStore : PizzaStore
    {
        public override IPizza CreatPizza(string type)
        {
            if (type.Equals("Cheese"))
            {
                return new NyCheesePizza();
            }
            else if (type.Equals("Ham"))
            {
                return new NyHamPizza();
            }
            else if (type.Equals("NyClam"))
            {
                return new NyClamPizza();
            }
            else
            {
                return null;
            }
        }
    }

    public class NyCheesePizza : CheesePizza
    {

    }

    public class NyHamPizza : HamPizza
    {

    }

    public class NyClamPizza : IPizza
    {
        public void Cook()
        {
        }

        public void Prepare()
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorys_FactoryMethod
{
    public interface IPizza
    {
        void Prepare();
        void Cook();
    }

    public class CheesePizza : IPizza
    {
        public void Cook()
        {
            
        }

        public void Prepare()
        {

        }
    }

    public class HamPizza : IPizza
    {
        public void Cook()
        {

        }

        public void Prepare()
        {

        }
    }
}

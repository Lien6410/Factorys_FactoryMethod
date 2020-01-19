using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorys_FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore nyStore = new NyPizzaStore();
            IPizza pizza = nyStore.OrderPizze("Cheese");


            //Product（Pizza）: 定義 factoryMethod（CreatePizza） 所造物件的介面。

            //ConcreteProduct（NYStyleCheesePizza）: 實作 Product。

            //Creator（PizzaStore）: 宣告 factoryMethod（必須傳回Product），和其他 client 可以 call 的 API。

            //ConcreteCreator（NYPizzaStore）: 實作 factoryMethod，回傳 ConcreteProduct 的 instance。

            //有個小細節，其實工廠方法不一定是 abstract。
            //也可以 Creator 就先偷偷實作 factoryMethod，回傳 Product，subclass 可以選擇要不要 override 工廠方法。


            //優點除了跟簡單工廠一樣，隱藏了創建物件的細節，最重要的是加入新產品不需要改動 Creator，你直接繼承 Creator 就好了 。
            //Client 的用法都是一樣不需要改，完全符合開放封閉守則。

            //缺點就是 ConcreteCreator 跟 ConcreteProduct 會成對的增加。
            //比如你今天想做加州披薩，你在定義完加州 pizza之後，還要再定義一個加州 pizza 工廠。
        }
    }
}

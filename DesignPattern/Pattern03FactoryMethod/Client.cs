using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pattern03FactoryMethod.Interface;
using Pattern03FactoryMethod.Models;

namespace Pattern03FactoryMethod
{
    internal class Client
    {
        public void Start()
        {
            DoStuff(new AppleFactory().Create());
            DoStuff(new BananaFactory().Create());
            DoStuff(new OrangeFactory().Create());

        }
        private void DoStuff(IFruit fruit)
        {
            fruit.Plant(10); //种植10颗新水果
            fruit.Grow(180);//生成180天
            Console.WriteLine($"{fruit.GetType().Name}收获{fruit.Harvest()}");

        }
    }
}

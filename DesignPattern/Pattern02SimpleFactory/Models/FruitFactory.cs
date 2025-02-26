using Pattern02SimpleFactory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern02SimpleFactory.Models
{
    public class FruitFactory
    {
        public static IFruit Create(string name)
        {
            switch (name)
            {
                case "Apple":
                    return new Apple();
                case "Banana":
                    return new Banana();
                case "Orange":
                    return new Orange();
                ///添加新水果，需要修改添加如下代码
                case "newFruit":
                    return new newFruit();
                default: 
                    return null;
            }
        }
    }
}

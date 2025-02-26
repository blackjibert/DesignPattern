using Pattern03FactoryMethod.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern03FactoryMethod.Models
{
    public class OrangeFactory : IFruitFactory
    {
        public IFruit Create()
        {
            return new Orange();
        }
    }
}

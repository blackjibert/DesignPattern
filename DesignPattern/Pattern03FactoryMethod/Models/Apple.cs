using Pattern03FactoryMethod.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Pattern03FactoryMethod.Models
{
    internal class Apple : IFruit
    {
        public double Amout { get; private set; }

        public void Grow(int days)
        {
                Amout *= days*0.85;
        }

        public double Harvest()
        {
            return Amout;
        }

        public void Plant(int amount)
        {
            Amout = amount;
        }
    }
}

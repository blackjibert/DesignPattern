using Pattern02SimpleFactory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern02SimpleFactory.Models
{
    internal class Banana : IFruit
    {
        public double Amout { get; private set; }

        public void Grow(int days)
        {
            Amout *= days*2;
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

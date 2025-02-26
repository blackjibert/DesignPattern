using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern03FactoryMethod.Interface
{
    public interface IFruit
    {
        /// <summary>
        /// 水果水量
        /// </summary>
        double  Amout { get; }
        
        /// <summary>
        /// 种植
        /// </summary>
        /// <param name="amount"></param>
        void Plant(int  amount);
        
        
        /// <summary>
        /// 生长
        /// </summary>
        /// <param name="days"></param>
        

        void Grow(int days);
        /// <summary>
        /// 收获
        /// </summary>
        /// <returns></returns>
        double Harvest();
    }
}

using Pattern03FactoryMethod.Models;

namespace Pattern03FactoryMethod
{
    public  class Program
    {
        #region 工厂方法模式 （Factory Method Pattern）
        /*        工厂方法模式是一种创建型设计模式，它通过定义一个抽象工厂方法(IFruitFactory)，由子类决定实例化哪一个具体类，
                而不是在基类中直接创建对象。这样可以提高代码的扩展性和可维护性。*/
        #endregion
        static void Main(string[] args)
        {
            new Client().Start();
            Console.ReadKey();
        }
    }
}

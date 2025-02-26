using Pattern03FactoryMethod.Models;

namespace Pattern03FactoryMethod
{
    public  class Program
    {
        #region 工厂方法模式 （Factory Method Pattern）
        /*        工厂方法模式是一种创建型设计模式，它通过定义一个抽象工厂方法(IFruitFactory)，由子类决定实例化哪一个具体类，
                而不是在基类中直接创建对象。这样可以提高代码的扩展性和可维护性。*/
        /*优点:
         * （1）、工厂方法模式就很好的减轻了工厂类的负担，把某一类/某一种“水果”交由一个工厂生产（克服了简单工厂的缺点）。
         * （2）、增加某一类“水果”并需要修改工厂类，只需要添加这类“水果”的工厂即可，使得工厂类符合开放-闭合原则。
         缺点:
         * （1）、相比简单工厂模式，实现略微复杂。
         * （2）、对于某些可以形成产品族的情况处理比较复杂。我们可以借助用抽象工厂来实现。
         */
        #endregion

        static void Main(string[] args)
        {
            new Client().Start();
            Console.ReadKey();
        }
    }
}

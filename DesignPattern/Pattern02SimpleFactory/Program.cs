using Pattern02SimpleFactory.Models;

namespace Pattern02SimpleFactory
{
    #region 简单工厂模式，也称静态工厂模式
/*    是一种创建对象的设计模式，它定义了一个工厂类。
    通过它可以根据不同的输入参数创建不同类型的对象。
    这种模式常用于类的实例化过程较为复杂或需要根据不同条件来决定对象类型的场景。
    结构:
- 工厂类（Factory Class）：负责创建产品对象的实例，根据传入的参数决定创建哪一类对象。
- 产品接口（Product Interface）：定义产品的共同接口，所有产品类都实现该接口。
- 具体产品类（Concrete Product）：实现产品接口的具体类，代表不同的产品。*/
  #endregion
        
public class Program
    {
        static void Main(string[] args)
        {
                var apple = FruitFactory.Create("Apple");
                var banana = FruitFactory.Create("Banana");
                var orange = FruitFactory.Create("Orange");
                var newFruit = FruitFactory.Create("newFruit");

            apple.Plant(10);  //种植10颗苹果树
            apple.Grow(180); //生成180天
            Console.WriteLine($"苹果收获{apple.Harvest()}");

            banana.Plant(10);//种植10颗香蕉树
            banana.Grow(180);//生成180天
            Console.WriteLine($"香蕉收获{banana.Harvest()}");

            orange.Plant(10); //种植10颗柑橘树
            orange.Grow(180);//生成180天
            Console.WriteLine($"柑橘收获{orange.Harvest()}");

            Console.ReadKey(); //等待用户按下任意键，然后再继续执行（或退出）程序

            newFruit.Plant(10); //种植10颗新水果
            newFruit.Grow(180);//生成180天
            Console.WriteLine($"新水果收获{newFruit.Harvest()}");



            /// 如果需要创建一个新的水果，需要修改及添加代码,进入第三种设计模式，工厂方法模式
        }
    }
}

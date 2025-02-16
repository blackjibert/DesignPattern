namespace Pattern01Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                //Counter counter5 = Counter.getInstanceLock();
                //Counter counter6 = Counter.getInstanceLock();

                // 开启一个新的任务（线程）,实现多线程
                Task.Factory.StartNew(()=>
                {
                    //饿汉式单例模式调用
                    //Counter counter1 = Counter.getInstance();
                    //Counter counter2 = Counter.getInstance();

                    //饿汉式单例模式调用
                    //Counter counter3 = Counter.Instance;
                    //Counter counter4= Counter.Instance;

                    //加入双重检查锁的单例模式调用,只会调用一次
                    //Counter counter5 = Counter.getInstanceLock();
                    //Counter counter6 = Counter.getInstanceLock();

                    //lazy懒加载
                    Counter counter7 = Counter.LazyInstance;
                    Counter counter8 = Counter.LazyInstance;
                });
            }
            //暂停一下
            Console.ReadKey();
        }
    }
}

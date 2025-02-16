using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern01Singleton
{
    internal  sealed class Counter
    {
        public Counter()
        {
            CreateTime=DateTime.Now;
            Console.WriteLine($"实例化对象:{CreateTime}");
        }
        public DateTime CreateTime { get; private set; }

        #region 第1种,懒汉式单例模式,适用于单线程环境,getInstance() 方法被调用时才创建
        private static Counter singleton = null;
        public static Counter getInstance()
        {
            if (singleton == null)
            {
                singleton = new Counter();
            }
            return singleton;
        }
        #endregion
        #region 第2种,饿汉式单例模式, 在类加载时就被自动初始化,并且在程序运行期间保持唯一实例,避免多线程问题。
        //public static Counter Instance=new Counter();
        #endregion

        #region 第3种,改进的懒汉式单例模式,加入双重检查锁
        private static readonly object lockObj = new object();
        public static Counter getInstanceLock()
        {
            if (singleton == null)  // 第一次检查（提高性能）
            {
                lock (lockObj)  // 线程同步
                {
                    if (singleton == null)  // 第二次检查（确保单例）
                    {
                        singleton = new Counter();
                    }
                }
            }
            return singleton;
        }
        #endregion
        #region 第4种,懒加载lazy
        private static readonly Lazy<Counter> lazyInstance = new Lazy<Counter>(() => new Counter());
        public static Counter LazyInstance => lazyInstance.Value;
        #endregion

        //第5种,IOC容器单例注册,prism
    }
}

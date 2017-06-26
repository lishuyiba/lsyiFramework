using System;
using System.Collections.Generic;
using System.Text;

namespace lsyi.Core.InfrastructureCore
{
    /// <summary>
    /// 
    /// lsy
    /// 
    /// 2017/6/26 上午11:30:13
    /// 
    /// 单列模式保持唯一性 提高性能
    /// </summary>
    public class Singleton
    {
        /// <summary>
        /// 字典数组
        /// </summary>
        private static readonly IDictionary<Type, object> allSingletons;

        static Singleton()
        {
            allSingletons = new Dictionary<Type, object>();
        }

        public static IDictionary<Type, object> AllSingletons
        {
            get
            {
                return allSingletons;
            }
        }
    }
    /// <summary>
    /// 
    /// lsy
    /// 
    /// 2017/6/26 上午11:30:13
    /// 
    /// 单列泛型模式
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Singleton<T> : Singleton
    {
        private static T _instance;

        public static T Instance
        {
            get
            {
                return _instance;
            }
            set
            {
                _instance = value;
                AllSingletons[typeof(T)] = value;
            }
        }
    }

    /// <summary>
    /// 
    /// lsy
    /// 
    /// 2017/6/26 上午11:30:13
    /// 
    /// 单列泛型数组模式
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class SingletonList<T> : Singleton<IList<T>>
    {
        static SingletonList()
        {
            Singleton<IList<T>>.Instance = new List<T>();
        }

        public new static IList<T> Instance  //重写父类字段值
        {
            get
            {
                return Singleton<IList<T>>.Instance;
            }
        }
    }

    /// <summary>
    /// 单列字典模式
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    /// <typeparam name="TValue"></typeparam>
    public class SingletonDictionary<TKey, TValue> : Singleton<IDictionary<TKey, TValue>>
    {
        static SingletonDictionary()
        {
            Singleton<Dictionary<TKey, TValue>>.Instance = new Dictionary<TKey, TValue>();
        }

        public new static IDictionary<TKey, TValue> Instance
        {
            get
            {
                return Singleton<Dictionary<TKey, TValue>>.Instance;
            }
        }
    }
}

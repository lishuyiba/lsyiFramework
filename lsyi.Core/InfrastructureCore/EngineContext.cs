using lsyi.Core.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace lsyi.Core.InfrastructureCore
{
    /// <summary>
    /// 
    /// lsy
    /// 
    /// 2017/6/26 上午11:30:13
    /// 
    /// 引擎上下文
    /// 
    /// 
    /// 为了保证系统线程当中可以高性能的使用容器驱动，又是唯一的实例，所以使用单例类进行托管
    /// 
    /// </summary>
    public class EngineContext
    {
        #region Initializtion Methods
        /// <summary>
        /// 确保方法同步实例化
        /// </summary>
        /// <param name="forceRecreate"></param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.Synchronized)]
        public static IEngine Initialize(bool forceRecreate)
        {
            Log.WriteLog("正在初始化实例.......");
            if (Singleton<IEngine>.Instance == null || forceRecreate) //forceRecreate 是否强制重新查找IOC容器
            {
                Singleton<IEngine>.Instance = CreateEngineInstance();
            }
            return Singleton<IEngine>.Instance;
        }
        #endregion


        /// <summary>
        /// 创建实例
        /// </summary>
        /// <returns></returns>
        public static IEngine CreateEngineInstance()
        {
            var typeFinder = new WebAppTypeFinder();
            Log.WriteLog("开始查找实现了IEngine接口的IOC容器.......");
            var engines = typeFinder.FindClassesOfType<IEngine>().ToArray();
            if (engines.Length > 0)
            {
                var defaultEngine = (IEngine)Activator.CreateInstance(engines[0]);//若查找到多个IOC容器，默认实例化第一个
                return defaultEngine;
            }
            else
            {
                Log.WriteLog("找不到实现了IEngine接口的IOC容器.......");
                throw new ApplicationException("找不到IOC容器");
            }
        }

        /// <summary>
        /// 获取当前引擎实例化对象
        /// </summary>
        public static IEngine Current
        {
            get
            {
                if (Singleton<IEngine>.Instance == null)
                {
                    Initialize(true);
                }
                return Singleton<IEngine>.Instance;
            }
        }
    }
}

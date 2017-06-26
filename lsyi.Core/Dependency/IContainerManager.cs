using Autofac;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace lsyi.Core.Dependency
{
    /// <summary>
    /// 
    /// lsy
    /// 
    /// 2017/6/26 上午11:30:13
    /// 
    /// IOC容器管理接口
    /// 
    /// </summary>
    public interface IContainerManager
    {
        T Resolve<T>(string key = "", ILifetimeScope scope = null) where T : class;

        object Resolve(Type type, ILifetimeScope scope = null);

        T[] ResolveAll<T>(string key = "", ILifetimeScope scope = null);

        T ResolveUnregistered<T>(ILifetimeScope scope = null) where T : class;

        object ResolveUnregistered(Type type, ILifetimeScope scope = null);

        bool TryResolve(Type serviceType, ILifetimeScope scope, out object instance);

        bool IsRegistered(Type serviceType, ILifetimeScope scope = null);

        object ResolveOptional(Type serviceType, ILifetimeScope scope = null);
    }
}

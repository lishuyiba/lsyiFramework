using Autofac;
using lsyi.Core.InfrastructureCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace lsyi.Autofac
{
    /// <summary>
    /// 
    /// lsy
    /// 
    /// 2017/6/26 上午11:30:13
    /// 
    /// 依赖注入接口
    /// 
    /// </summary>
    public interface IDependencyAutofacRegistrar
    {
        void Register(ContainerBuilder builder, ITypeFinder typeFinder);
    }
}

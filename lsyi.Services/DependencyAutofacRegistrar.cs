using lsyi.Autofac;
using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using lsyi.Core.InfrastructureCore;
using lsyi.Services.Blog;
using lsyi.Services.Demo;

namespace lsyi.Services
{
    /// <summary>
    /// 
    /// lsy
    /// 
    /// 2017/6/26 上午11:30:13
    /// 
    /// 实现依赖注入接口
    /// 
    /// </summary>
    public class DependencyAutofacRegistrar : IDependencyAutofacRegistrar
    {
        public void Register(ContainerBuilder builder, ITypeFinder typeFinder)
        {
            builder.RegisterType<TestService>().As<ITest>().SingleInstance();
            builder.RegisterType<UsersServies>().As<IUsersServies>().SingleInstance();
        }
    }
}

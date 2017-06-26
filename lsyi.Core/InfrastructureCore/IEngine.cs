using lsyi.Core.Dependency;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace lsyi.Core.InfrastructureCore
{
    /// <summary>
    /// 
    /// lsy
    /// 
    /// 2017/6/26 上午11:30:13
    /// 
    /// 引擎接口
    /// 
    /// 要使用具体的IOC那就得继承IEngine这个接口。
    /// 
    /// 本项目使用 Autofac
    /// 
    /// </summary>
    public interface IEngine
    {

        #region AspNet Core
        IServiceProvider ConfigureServices(IServiceCollection services);
        void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory);

        void Initialize(IConfigurationRoot configuration, IHostingEnvironment env);
        #endregion

        #region ContainerManager

        ContainerManager ContainerManager { get; }

        #endregion

        #region Resolve

        T Resolve<T>() where T : class;

        object Resolve(Type type);

 

        #endregion

        #region ResolveAll



        T[] ResolveAll<T>();




        #endregion
    }
}

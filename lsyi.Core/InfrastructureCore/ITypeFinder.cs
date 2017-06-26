using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace lsyi.Core.InfrastructureCore
{
    /// <summary>
    /// 
    /// lsy
    /// 
    /// 2017/6/21 上午09:30:13
    /// 
    /// 类型查找接口
    /// 
    /// </summary>
    public interface ITypeFinder
    {
        IList<Assembly> GetAssemblies();
        IEnumerable<Type> FindClassesOfType(Type assignTypeFrom, bool onlyConcreteClasses = true);

        IEnumerable<Type> FindClassesOfType(Type assignTypeFrom, IEnumerable<Assembly> assemblies, bool onlyConcreteClasses = true);

        IEnumerable<Type> FindClassesOfType<T>(bool onlyConcreteClasses = true);

        IEnumerable<Type> FindClassesOfType<T>(IEnumerable<Assembly> assemblies, bool onlyConcreteClasses = true);
       
    }
}

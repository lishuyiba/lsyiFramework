using lsyi.Autofac;
using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using lsyi.Core.InfrastructureCore;
using lsyi.Data.Repository;

namespace lsyi.Data
{
    class DependencyAutofacRegistrar : IDependencyAutofacRegistrar
    {
        public void Register(ContainerBuilder builder, ITypeFinder typeFinder)
        {
            builder.RegisterGeneric(typeof(Repository<>)).As(typeof(IRepository<>)).InstancePerDependency();
        }
    }
}

using Autofac;
using NimblesPros.DotNetConf.Core.Interfaces;
using NimblesPros.DotNetConf.Core.Services;

namespace NimblesPros.DotNetConf.Core;

public class DefaultCoreModule : Module
{
  protected override void Load(ContainerBuilder builder)
  {
    builder.RegisterType<ToDoItemSearchService>()
        .As<IToDoItemSearchService>().InstancePerLifetimeScope();
  }
}

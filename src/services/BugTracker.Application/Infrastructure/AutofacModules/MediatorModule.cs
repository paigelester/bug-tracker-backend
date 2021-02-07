using Autofac;
using MediatR;
using System.Reflection;

namespace BugTracker.Application.Infrastructure.AutofacModules
{
    public class MediatorModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            // register mediator
            _ = builder.RegisterAssemblyTypes(typeof(IMediator).GetTypeInfo().Assembly).AsImplementedInterfaces();
        }
    }
}

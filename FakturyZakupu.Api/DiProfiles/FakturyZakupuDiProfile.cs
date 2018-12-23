using Autofac;
using FakturyZakupu.Bll;
using FakturyZakupu.Bll.Interfaces;
using FakturyZakupu.Dal;
using FakturyZakupu.Dal.Interfaces;
using System.Reflection;

namespace FakturyZakupu.Api.DiProfiles
{
    public class FakturyZakupuDiProfile : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
            builder.RegisterAssemblyTypes(typeof(IFakturyZakupuApiAsembly).GetTypeInfo().Assembly);
            //builder.RegisterAssemblyTypes(typeof(IFakturyZakupuBllInterfacesAssembly).GetTypeInfo().Assembly);
            //builder.RegisterAssemblyTypes(typeof(IFakturyZakupuDalInterfacesAssembly).GetTypeInfo().Assembly);
            builder.RegisterAssemblyTypes(typeof(IFakturyZakupuBllAssembly).GetTypeInfo().Assembly).AsImplementedInterfaces();
            builder.RegisterAssemblyTypes(typeof(IFakturyZakupuDalAssembly).GetTypeInfo().Assembly).AsImplementedInterfaces();

            //builder.RegisterType<FakturyZakupuConnectionProvider>().As<IFakturyZakupuConnectionProvider>().WithParameter("connectionString", "");

            //builder.RegisterType<FakturyZakupuService>().As<IFakturyZakupuService>();
        }
    }
}

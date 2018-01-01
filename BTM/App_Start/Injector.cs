using BTMService;
using Injection;
using Injection.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTM.App_Start
{
    public class Injector
    {
        public static IInjectionContainer Container { get; set; }

        static Injector()
        {
            Container = new Container();
        }

        public static void Configure()
        {
            Container.Register<IBusService, BusService>().Singleton();
            Container.Register<ISeatService, SeatService>().Singleton();
            Container.Register<ISpecialUserService, SpecialUserService>().Singleton();

            //Container.Register<IDepartmentService, DepartmentService>().Singleton();
            //Container.Register<DepartmentController, DepartmentController>();
            //ControllerBuilder.Current.SetControllerFactory(new InjectionControllerFactory());
        }

        internal static void configure()
        {
            throw new NotImplementedException();
        }
    }
}
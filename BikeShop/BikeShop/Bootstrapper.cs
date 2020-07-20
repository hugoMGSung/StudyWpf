using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Windows;

namespace BikeShop
{
    public class Bootstrapper : BootstrapperBase
    {
        private readonly SimpleContainer container = new SimpleContainer();

        public Bootstrapper()
        {
            Initialize();
        }

        protected override void BuildUp(object instance)
        {
            container.BuildUp(instance);
        }

        protected override void Configure()
        {
            //base.Configure();
            container.Instance(container);
            container.Singleton<IWindowManager, WindowManager>().Singleton<IEventAggregator, EventAggregator>();
            // 필요한 View(Window)를 싱글톤으로 등록
            //container.Singleton<MenuViewModel>();
            //container.Singleton<ProductModel>();
            //container.Singleton<ProductsManagementViewModel>();
            container.Singleton<TestDBViewModel>();
        }

        protected override IEnumerable<object> GetAllInstances(Type service)
        {
            return container.GetAllInstances(service);
        }

        protected override object GetInstance(Type service, string key)
        {
            return container.GetInstance(service, key);
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            // base.OnStartup(sender, e);
            //DisplayRootViewFor<MenuViewModel>();  // 메뉴 뷰모델 추가
        }
    }
}

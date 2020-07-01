using Autofac;
using GalaSoft.MvvmLight.Views;
using System;

namespace LoginApp.Services
{
    class NavigationServices : INavigationService
    {
        public string CurrentPageKey => throw new NotImplementedException();
        public NavigationServices()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<NavigationServices>().As<INavigationService>().SingleInstance();
        }


        public void GoBack()
        {
            throw new NotImplementedException();
        }

        public void NavigateTo(string pageKey)
        {
            throw new NotImplementedException();
        }

        public void NavigateTo(string pageKey, object parameter)
        {
            throw new NotImplementedException();
        }
    }
}





























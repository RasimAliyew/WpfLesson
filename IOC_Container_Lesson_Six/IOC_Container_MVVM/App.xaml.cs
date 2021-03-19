using IOC_Container_MVVM.View;
using IOC_Container_MVVM.ViewModel;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace IOC_Container_MVVM
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Container container { get; set; }
        
        protected override void OnStartup(StartupEventArgs e)
        {
            container = new Container();
            container.RegisterSingleton<MainVM>();
            container.RegisterSingleton<SignInVM>();
            container.RegisterSingleton<SignUpVM>();
            container.RegisterSingleton<MainWindow>();
            var main = container.GetInstance<MainWindow>();
            main.Show();

            //var a = container.GetInstance<MainVM>();
            base.OnStartup(e);
        }
    }
}

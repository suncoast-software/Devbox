using Devbox.Data.Factories;
using Devbox.Interfaces;
using Devbox.Navigation;
using Devbox.Services;
using Devbox.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Windows;

namespace Devbox
{
    public partial class App : Application
    {
        internal readonly IHost _host;

        public App()
        {
           _host = Host.CreateDefaultBuilder().ConfigureServices(services =>
           {
               services.AddSingleton<AppViewModel>();
               services.AddTransient<AppDbContextFactory>();
               services.AddSingleton<IDataService, DataService>();
               services.AddSingleton<INavigator, Navigator>();
               services.AddSingleton<ISystemMessage, SystemMessageService>();
               services.AddSingleton<MainWindow>(s => new MainWindow()
               {
                   DataContext = s.GetRequiredService<AppViewModel>()
               });
           }).Build();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            _host.Start();
            MainWindow = _host.Services.GetRequiredService<MainWindow>();
            MainWindow.Show();
            base.OnStartup(e);
        }
    }
}

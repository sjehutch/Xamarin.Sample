using System;
using System.Net.Http;
using App1.Interfaces;
using App1.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

namespace App1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            
            DependencyService.Register<ILoggerService,LoggerService>();
            DependencyService.Register<ITaxCalculatorService,TaxCalculatorService>();
            DependencyService.Register<HttpClient>();
            Current.MainPage = new NavigationPage(new MainPage());
        }
        
        

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
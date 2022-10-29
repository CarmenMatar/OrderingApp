using Ordering_App.Services;
using Ordering_App.Views;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ordering_App
{
    public partial class App : Application
    {
        static orderService _orderService;

        public static orderService orderService
        {
            get
            {
                if(_orderService == null)
                {
                    _orderService = new orderService(Path.Combine(
                        Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),"Order.db3"));
                }
                return _orderService;
            }
        }

        public App()
        {
            InitializeComponent();
            MainPage = new AppShell();

        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

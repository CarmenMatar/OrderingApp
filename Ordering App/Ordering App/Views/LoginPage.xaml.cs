using Ordering_App.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ordering_App.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        loginView loginView;

        public LoginPage()
        {
            loginView = new loginView();
            InitializeComponent();
            BindingContext = loginView;
        }
    }
}
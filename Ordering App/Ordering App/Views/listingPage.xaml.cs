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
    public partial class listingPage : ContentPage
    {
        listingView listingview;

        public listingPage()
        {
            InitializeComponent();
            BindingContext = listingview = new listingView(Navigation);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            listingview.OnAppearing();
        }
    }
}
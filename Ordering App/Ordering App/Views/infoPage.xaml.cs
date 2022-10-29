using Ordering_App.Models;
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
    public partial class infoPage : ContentPage
    {
        infoView infoview;
        public Order order { get; set; }

        public infoPage()
        {
            InitializeComponent();
            BindingContext = infoview = new infoView();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
        }


        public infoPage(Order ord)
        {
            InitializeComponent();
            BindingContext = infoview = new infoView();

            if(ord != null)
            {
                _ = ((infoView)BindingContext);
            }
        }



    }
}
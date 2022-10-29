using Ordering_App.Models;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace Ordering_App.ViewModels
{
    public class infoView : BaseOrderViewModel
    {
        public Command SaveCommand { get; }
        public Command CancelCommand { get; }


        public infoView ()
        {
            SaveCommand = new Command(OnSave);
            CancelCommand = new Command(OnCancel);

            this.PropertyChanged += (_,__) => SaveCommand.ChangeCanExecute();

            Order = new Order();
        }

        private async void OnSave()
        {
            var order = Order;

            await App.orderService.AddOrderAsync(order);
            await Shell.Current.GoToAsync("//listingPage");
        }

        private async void OnCancel()
        {
            await Shell.Current.GoToAsync("//listingPage");
        }

    }
}

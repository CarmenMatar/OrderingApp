using Ordering_App.Models;
using Ordering_App.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ordering_App.ViewModels
{
    public class listingView : BaseOrderViewModel
    {
        public Command LoadOrderCommand { get; }
        public ObservableCollection<Order> orders { get; }
        public Command AddOrderCommand { get; }
        public Command OrderTappedEdit { get; }
        public Command OrderTappedDelete {get;}

        public listingView (INavigation _navigation)
        {
            LoadOrderCommand = new Command(async () => await ExecuteLoadOrderCommand());
            orders = new ObservableCollection<Order>();
            AddOrderCommand = new Command(OnAddOrder);
            OrderTappedEdit = new Command<Order>(OnEditOrder);
            OrderTappedDelete = new Command<Order>(OnDeleteOrder);
            Navigation = _navigation;
        }

        public void OnAppearing()
        {
            IsBusy = true;
        }

        async Task ExecuteLoadOrderCommand ()
        {
            IsBusy = true;
            try
            {
                orders.Clear();
                var ordersList = await App.orderService.GetAllOrdersAsync();
                foreach (var ord in ordersList)
                {
                    orders.Add(ord);
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                IsBusy = false;
            }  
        }


        private async void OnAddOrder(object obj)
        {
            await Shell.Current.GoToAsync("//infoPage");
        }
        
        private async void OnEditOrder (Order ord)
        {
            await Navigation.PushAsync(new infoPage(ord));
        }
        private async void OnDeleteOrder (Order ord)
        {
            if(ord == null)
            {
                return;
            }
            await App.orderService.DeleteOrderAsync(ord.orderId);
            await ExecuteLoadOrderCommand();
        }

    }
}

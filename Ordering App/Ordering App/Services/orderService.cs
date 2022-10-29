using Ordering_App.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ordering_App.Services
{
    public class orderService : orderInterface
    {
        public SQLiteAsyncConnection _database;

        public orderService (string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Order>().Wait();
        }


        // Add / Update Order
        public async Task<bool> AddOrderAsync(Order order)
        {
            if (order.orderId > 0) { 
                    await _database.UpdateAsync(order);
            }
            else
            {
                await _database.InsertAsync(order);
            }
            return await Task.FromResult(true);
        }

        // Delete Order
        public async Task<bool> DeleteOrderAsync(int id)
        {
            await _database.DeleteAsync<Order>(id);
            return await Task.FromResult(true);
        }

        //Get All Orders 
        public async  Task<IEnumerable<Order>> GetAllOrdersAsync()
        {
            return await _database.Table<Order>().ToListAsync();
        }

        //Get Order
        public async Task<Order> GetOrderAsync(int id)
        {
            return await Task.FromResult( await _database.Table<Order>().Where(p => p.orderId == id).FirstOrDefaultAsync());
        }

        // This method won't be used
        public Task<bool> UpdateOrderAsync(Order order)
        {
            throw new NotImplementedException();
        }
    }
}

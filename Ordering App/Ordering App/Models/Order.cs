using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Ordering_App.Models
{
    public class Order
    {

        [PrimaryKey, AutoIncrement]
        public int orderId { get; set; }
        public DateTime orderDate { get; set; }
        public int orderAmount { get; set; }
        public string orderDescription { get; set; }
        public int clientID { get; set; }
        public DateTime alteredDate { get; set; }
    }
}

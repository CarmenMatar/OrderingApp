using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Ordering_App.Models
{
    public class Item
    {

        [PrimaryKey, AutoIncrement]
        public int itemId { get; set; }
        public string itemName { get; set; }
        public int itemQuantity { get; set; }
    }
}

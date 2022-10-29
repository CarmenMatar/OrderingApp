using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Ordering_App.Models
{
    public class client
    {

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public string password { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLite1;

namespace SQLite1.Models
{
    public class Users
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}

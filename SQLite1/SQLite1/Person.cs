using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace SQLite1
{
    public class Person
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        
    }
}

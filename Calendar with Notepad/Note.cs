using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Calendar_with_Notepad
{
    public class Note
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }

    }
}

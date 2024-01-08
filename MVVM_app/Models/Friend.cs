using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVVM_app.Models
{
    [Table("Friends")]
    public class Friend
    {
        [PrimaryKey, AutoIncrement, Column("ID")]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string PhoneNumber { get; set; }

    }
}

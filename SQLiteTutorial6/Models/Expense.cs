using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace SQLiteTutorial6.Models
{
    public class Expense
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(100)]
        public string Description { get; set; }
        public double Amount { get; set; }
        [MaxLength(50)]
        public string Category { get; set; }
        public DateTime Date { get; set; }


    }
}

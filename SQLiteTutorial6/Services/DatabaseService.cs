using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLiteTutorial6.Models;
using SQLite;

namespace SQLiteTutorial6.Services
{
    public  class DatabaseService
    {
        private readonly SQLiteAsyncConnection _database; // SQLite asynchronous connection

        public DatabaseService(string dbPath) // Constructor that initializes the database connection
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Expense>().Wait(); // Create the Expense table if it doesn't exist
        }

        public Task<List<Expense>>GetExpensesAsync() // Retrieve all expenses ordered by date descending
        {
            return _database.Table<Expense>().OrderByDescending(e => e.Date).ToListAsync();
        }

    }
}

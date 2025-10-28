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

        public Task<int>SaveExpenseAsync(Expense expense) // Save or update an expense record
        {
            if (expense.Id != 0) // If the expense has an Id, update the existing record
                return _database.UpdateAsync(expense);
            else // Otherwise, insert a new record
                return _database.InsertAsync(expense);
        }

        public Task<int> DeleteExpenseAsync(Expense expense) // Delete an expense record
        {
            return _database.DeleteAsync(expense); // Delete the specified expense from the database
        }


    }
}

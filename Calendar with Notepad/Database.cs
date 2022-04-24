using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Calendar_with_Notepad
{
    public class Database
    {
        readonly SQLiteAsyncConnection _database;

        public Database(string dbPath)
        {
            //Establishing the conection
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Note>().Wait();
        }

        // Show the registers
        public Task<List<Note>> GetNotesAsync()
        {
            return _database.Table<Note>().ToListAsync();
        }

        // Save registers
        public Task<int> SaveNotesAsync(Note note)
        {
            return _database.InsertAsync(note);
        }

        // Delete registers
        public Task<int> DeleteNotesAsync(Note note)
        {
            return _database.DeleteAsync(note);
        }

        // Save registers
        public Task<int> UpdateNotesAsync(Note note)
        {
            return _database.UpdateAsync(note);
        }
    }
}

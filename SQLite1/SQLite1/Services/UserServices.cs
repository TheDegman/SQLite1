using SQLite;
using SQLite1.Models;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace SQLite1.Services
{
    public static class UserServices
    {
        private static SQLiteAsyncConnection db;

        private static async Task Init()
        {
            if (db != null)
                return;
            var databasePath = Path.Combine(FileSystem.AppDataDirectory, "MyData.db");

            db = new SQLiteAsyncConnection(databasePath);
            await db.CreateTableAsync<Users>();
        }

        public static async Task Dodavanje(string username, string password)
        {
            await Init();
            var user = new Users
            {
                Username = username,
                Password=password
            };
            var id=await db.InsertAsync(user);
        }

        public static async Task Brisanje(int id)
        {
            await Init();
            await db.DeleteAsync<Users>(id);
        }

        public static async Task<IEnumerable<Users>> Ispis()
        {
            await Init();
            var user=await db.Table<Users>().ToListAsync();
            return user;
        }
    }
}
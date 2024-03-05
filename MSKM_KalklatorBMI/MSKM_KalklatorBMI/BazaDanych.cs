using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MSKM_KalklatorBMI
{
    public class BazaDanych
    {
        readonly SQLiteAsyncConnection _database;

        public BazaDanych(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Uzytkownik>().Wait();
        }

        public Task<int> ZapiszUzytkownikaAsync(Uzytkownik uzytkownik)
        {
            return _database.InsertAsync(uzytkownik);
        }

        public Task<List<Uzytkownik>> WyswietlUzytkownikaAsync()
        {
            return _database.Table<Uzytkownik>().ToListAsync();
        }

    }
}

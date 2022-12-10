using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Magpie.Models;
using SQLite;
using SQLiteNetExtensions.Extensions;

namespace Magpie.Services.Data
{
    public class MagpieContext
    {
        private SQLiteAsyncConnection database;

        public MagpieContext(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Concert>().Wait();
            database.CreateTableAsync<FoodPlace>().Wait();
        }

        // FoodPlace DB methods

        public async Task<int> SaveFoodPlaceAsync(FoodPlace place)
        {
            if (place.Id == 0)
                return await database.InsertAsync(place);
            else
                return await database.UpdateAsync(place);
        }
        public async Task<IEnumerable<FoodPlace>> GetFoodPlacesAsync()
        {
            return await database.Table<FoodPlace>().ToListAsync();
        }

        // Concert DB methods
        public async Task<int> SaveConcertAsync(Concert concert)
        {
            if (concert.Id == 0)
                return await database.InsertAsync(concert);
            else
                return await database.UpdateAsync(concert);
        }

        public async Task<IEnumerable<Concert>> GetConcertsAsync()
        {
            return await database.Table<Concert>().ToListAsync();
        }

    }
}

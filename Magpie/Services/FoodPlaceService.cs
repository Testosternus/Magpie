using Magpie.Models;
using Magpie.Services.Interfaces;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magpie.Services
{
    public class FoodPlaceService : IFoodService
    {
        private static Random rnd = new Random();
        public async Task<FoodPlace> GenerateOptionAsync()
        {
            IEnumerable<FoodPlace> foodPlaces = await MauiProgram.Database.GetFoodPlacesAsync();
            FoodPlace selected = foodPlaces.ElementAtOrDefault(rnd.Next(0, foodPlaces.Count()));

            await updateSelectedChoice(selected);

            return selected;
        }

        private async Task updateSelectedChoice(FoodPlace selected)
        {
            selected.LastChosen = DateTime.Now;
            Debug.Assert(selected.LastChosen.HasValue, "lastChosen is null", "Selected food place did not receive a LastChosen value correctly.");
            Debug.WriteLine($"[UPDATE] DaysAgo value: {selected.DaysAgo}");

            await MauiProgram.Database.SaveFoodPlaceAsync(selected);
        }

        public async Task<IEnumerable<FoodPlace>> GetDataAsync()
        {
            return await MauiProgram.Database.GetFoodPlacesAsync();
        }
    }
}

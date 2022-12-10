using Magpie.Models;
using Magpie.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magpie.Services
{
    public class ConcertService : IConcertService
    {
        public async Task<IEnumerable<Concert>> GetDataAsync()
        {
            return await MauiProgram.Database.GetConcertsAsync();
        }
    }
}

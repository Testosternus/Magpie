using Magpie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magpie.Services.Interfaces
{
    public interface IFoodService : IDataService<FoodPlace>
    {
        Task<FoodPlace> GenerateOptionAsync();
    }
}

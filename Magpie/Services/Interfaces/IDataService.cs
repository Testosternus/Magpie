using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magpie.Services.Interfaces
{
    public interface IDataService<T> where T : class
    {
        /* ADD GENERIC CRUD LATER
        Task<int> SaveAsync(T entity);
        Task<T> FindByIdAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        Task<int> CountAsync();
        */
        Task<IEnumerable<T>> GetDataAsync();
    }
}

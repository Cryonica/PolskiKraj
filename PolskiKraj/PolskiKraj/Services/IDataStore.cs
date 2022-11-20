using System.Collections.Generic;
using System.Threading.Tasks;

namespace PolskiKraj.Services
{
    public interface IDataStore<T>
    {
        Task<bool> AddItemAsync(T item);
        Task<bool> UpdateItemAsync(T item);
        Task<bool> DeleteItemAsync(string sample);
        Task<T> GetItemAsync(string sample);
        Task<IEnumerable<T>> GetItemsAsync(bool forceRefresh = false);
    }
}

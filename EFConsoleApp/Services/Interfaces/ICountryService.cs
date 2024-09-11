using EFConsoleApp.Models;

namespace EFConsoleApp.Services.Interfaces
{
    internal interface ICountryService
    {
        Task<List<Country>> GetAllAsync();
        Task CreateAsnyc(Country country);
        Task<Country> GetByIdAsync(int id);
        Task DeleteAsync(int id);
        Task EditAsync(int id,Country country);
    }
}

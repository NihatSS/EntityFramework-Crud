using EFConsoleApp.Data;
using EFConsoleApp.Exceptions;
using EFConsoleApp.Models;
using EFConsoleApp.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EFConsoleApp.Services
{
    internal class CountryService : ICountryService
    {

        private readonly AppDbContext _context;
        public CountryService()
        {
            _context = new AppDbContext();

        }



        public async Task<List<Country>> GetAllAsync()
        {
            return await _context.Countries.ToListAsync();
        }

        public async Task CreateAsnyc(Country country)
        {
            await _context.Countries.AddAsync(country);
            await _context.SaveChangesAsync();
        }

        public async Task<Country> GetByIdAsync(int id)
        {
            return await _context.Countries.FirstOrDefaultAsync(c => c.Id == id) ?? throw new NotFoundException("Data not found");
        }

        public async Task DeleteAsync(int id)
        {
            var existCountry = await _context.Countries.FindAsync(id);
            _context.Countries.Remove(existCountry);
            await _context.SaveChangesAsync();
        }

        public async Task EditAsync(int id, Country country)
        {
            var existCountry = await _context.Countries.FindAsync(id);

            existCountry.Name = country.Name;

            await _context.SaveChangesAsync();

        }
    }
}

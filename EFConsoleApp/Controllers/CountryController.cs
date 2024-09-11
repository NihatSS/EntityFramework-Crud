using EFConsoleApp.Models;
using EFConsoleApp.Services;
using EFConsoleApp.Services.Interfaces;

namespace EFConsoleApp.Comtrollers
{
    internal class CountryController
    {

        private readonly ICountryService _countryService;

        public CountryController()
        {
            _countryService = new CountryService();
        }

        public async Task GetAllAync()
        {
            foreach (var item in await _countryService.GetAllAsync())
            {
                 Console.WriteLine("Country : " + item.Name);
            }
        }

        public async Task CreateAsync()
        {
            Console.WriteLine("Enter the country name :");
            Country: string countryName = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(countryName))
            {
                Console.WriteLine("Invalid input! Please enter the corret country :");
                goto Country;
            }

            await _countryService.CreateAsnyc(new Country { Name = countryName });
        }


        public async Task GetByIdAsync()
        {
            Console.WriteLine("Enter the country id :");
            Num: string strNum = Console.ReadLine();

            bool isCorrectIdFormat = int.TryParse(strNum, out var id);

            if (isCorrectIdFormat)
            {
                try
                {
                    var response = await _countryService.GetByIdAsync(id);
                    Console.WriteLine(response.Name);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message + "," + "Please add country id again: ");
                    goto Num;
                }
            }
            else
            {
                Console.WriteLine("Invalid id! Please enter corret id :");
                goto Num;
            }
        }

        public async Task DeleteByIdAsync()
        {
            Console.WriteLine("Enter the country id :");
            Num: string strNum = Console.ReadLine();

            bool isCorrectIdFormat = int.TryParse(strNum, out var id);

            if (isCorrectIdFormat)
            {
                await _countryService.DeleteAsync(id);
                Console.WriteLine("Successfully deleted!");
            }
            else
            {
                Console.WriteLine("Invalid id! Please enter corret id :");
                goto Num;
            }
        }

        public async Task EditAsync()
        {
            Console.WriteLine("Enter the country id :");
            Num: string strNum = Console.ReadLine();

            bool isCorrectIdFormat = int.TryParse(strNum, out var id);

            if (isCorrectIdFormat)
            {
                Console.WriteLine("Enter new county name :");
                Country: string newCountryName = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(newCountryName))
                {
                    Console.WriteLine("Invalid input! Please enter the corret country name :");
                    goto Country;
                }

                await _countryService.EditAsync(id, new Country { Name = newCountryName });
                Console.WriteLine("Country successfully changed!");
            }
            else
            {
                Console.WriteLine("Invalid id! Please enter corret id :");
                goto Num;
            }
        }
    }
}

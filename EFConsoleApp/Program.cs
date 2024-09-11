using EFConsoleApp.Comtrollers;
using EFConsoleApp.Data;
using EFConsoleApp.Models;
using System.Runtime.CompilerServices;


//AppDbContext context = new AppDbContext();


//void CreateCountry(Country country)
//{
//    context.Countries.Add(country);
//    context.SaveChanges();
//}

//void GetAllCountries()
//{
//    var datas = context.Countries.ToList();

//    foreach (var item in datas)
//    {
//        Console.WriteLine(item.Name);
//    }
//}

//CreateCountry(new Country { Name = "Norvec" });

//GetAllCountries();

CountryController countryController = new();

//await countryController.DeleteByIdAsync();

await countryController.GetByIdAsync();

//await countryController.EditAsync();

//await countryController.CreateAsync();

await countryController.GetAllAync();
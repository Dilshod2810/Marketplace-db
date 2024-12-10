using System.Threading.Channels;
using System.Xml.Serialization;
using Domain.Models;
using Infrastructure.Services.ProductService;
using Infrastructure.Services.QueryService;
using Infrastructure.Services.UserService;

UserService userService = new UserService();
ProductService productService = new ProductService();

while (true)
{
    Console.WriteLine("\nВыберите действие:");
    Console.WriteLine("1. Управление компаниями");
    Console.WriteLine("2. Управление сотрудниками");
    Console.WriteLine("0. Выход");

    var choice = Console.ReadLine();

    if (choice == "1")
    {
        ManageCompanies();
    }
    else if (choice == "2")
    {
        ManageEmployees();
    }
    else if (choice == "0")
    {
        Console.WriteLine("Завершение работы...");
        break;
    }
    else
    {
        Console.WriteLine("Неверный ввод. Попробуйте снова.");
    }
}

void ManageCompanies()
{
    while (true)
    {
        Console.WriteLine("1. Получить список всех пользователей и их торговые названия.");
        Console.WriteLine("0. Выход");
        
        var choice = Console.ReadLine();
        if (choice == "1")
        {
            var query = QueryService.ShowUsersMarkets();
            foreach (var item in query)
            {
                Console.WriteLine($"Имя: {item.FirstName}, {item.MarketName}");
            }
        }
        else if (choice == "0")
        {
            break;
        }
    }
}

void ManageEmployees()
{
    while (true)
    {
        Console.WriteLine("1. Получить список всех продуктов с их категориями");
        Console.WriteLine("0. Выход");
        var choice = Console.ReadLine();
        if (choice == "1")
        {
            var query = QueryService.ShowProductCategorie();
            foreach (var item in query)
            {
                Console.WriteLine($"Название: {item.ProductName} , Категория: {item.CategoryName}"); 
            }
        }
        else if (choice == "0")
        {
            break;
        }
    }
}

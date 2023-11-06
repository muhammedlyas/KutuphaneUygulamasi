using LibraryApp.Repositories.Interface;
using LibraryApp.Repositories.Services;

namespace LibraryApp.Data;

public static class ServiceRegistration
{
    public static void AddPersistanceLayer (this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped< IAccountService, AccountService>();
        serviceCollection.AddScoped< IBookService, BookService>();


    }
}
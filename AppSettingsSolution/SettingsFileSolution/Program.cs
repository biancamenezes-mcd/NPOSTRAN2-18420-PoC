// See https://aka.ms/new-console-template for more information

using Library.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Payment.App;

public class Program
{
    public static void Main(string[] args)
    {
        var service = new ServiceCollection();

        ConfigureService(service);

        var serviceProvider = service.BuildServiceProvider();

        var application = serviceProvider.GetService<Events>();

        application!.GenerateEvent();

    }

    public static void ConfigureService(IServiceCollection service)
    {
        service.AddSingleton<Events>();
        service.AddLibraryDependencies();
    }
}
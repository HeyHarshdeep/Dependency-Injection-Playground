using DI_6_Conditional_DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

internal class Program
{
    private static void Main(string[] args)
    {
        var collection = new ServiceCollection();
        collection.AddScoped<IndiaTaxCalculator>();
        collection.AddScoped<EuropeTaxCalculator>();

        collection.AddScoped<Func<UserLocationEnum, ITaxCalculator>>(
            serviceProvider => key =>
            {
                switch (key)
                {
                    case UserLocationEnum.India: return serviceProvider.GetService<IndiaTaxCalculator>();
                    case UserLocationEnum.Europe: return serviceProvider.GetService<EuropeTaxCalculator>();
                    default: return null;
                }
            });

        collection.AddScoped<Purchase>();

        var provider = collection.BuildServiceProvider();

        var purchase = provider.GetService<Purchase>();
        var totalCharge = purchase.CheckOut(UserLocationEnum.India);
        Console.Clear();
        Console.WriteLine(totalCharge);

        Console.ReadKey();
    }
}
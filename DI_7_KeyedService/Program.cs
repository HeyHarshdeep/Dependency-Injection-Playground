using DI_7_KeyedService;
using Microsoft.Extensions.DependencyInjection;

var collection = new ServiceCollection();

collection.AddKeyedScoped<ITaxCalculator, IndiaTaxCalculator>(UserLocationEnum.India);
collection.AddKeyedScoped<ITaxCalculator, EuropeTaxCalculator>(UserLocationEnum.Europe);

var provider = collection.BuildServiceProvider();

var obj = provider.GetKeyedService<ITaxCalculator>(UserLocationEnum.Europe);

var val = obj.Calculate();

Console.WriteLine($"Your Tax is "+ val);

Console.ReadKey();
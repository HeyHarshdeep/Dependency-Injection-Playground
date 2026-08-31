using Microsoft.Extensions.DependencyInjection;

IServiceCollection collection = new ServiceCollection();

collection.AddScoped<Scoped>();
collection.AddTransient<Transient>();

var service = collection.BuildServiceProvider();
Parallel.For(1, 10, i =>
{

    var scopedObject = service.GetRequiredService<Scoped>();
    var transientObject = service.GetRequiredService<Transient>();

    Console.WriteLine($"Scoped Id:  {scopedObject.GetHashCode()}");
    Console.WriteLine($"Transient Id:  {transientObject.GetHashCode()}");

});

Console.WriteLine("----------");

for (int j= 0; j < 10; j++){



    var scopedObject = service.GetRequiredService<Scoped>();
    var transientObject = service.GetRequiredService<Transient>();

    Console.WriteLine($"Scoped Id:  {scopedObject.GetHashCode()}");
    Console.WriteLine($"Transient Id:  {transientObject.GetHashCode()}");

}
Console.ReadKey();

public class Scoped()
{

}

public class Transient()
{

}
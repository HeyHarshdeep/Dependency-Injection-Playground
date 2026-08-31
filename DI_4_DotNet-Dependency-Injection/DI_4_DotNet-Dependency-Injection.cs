using Microsoft.Extensions.DependencyInjection;

IServiceCollection collection = new ServiceCollection();

collection.AddScoped<IDataAccess, DataAccessMySql>();
collection.AddScoped<IBusiness, Business>();
collection.AddScoped<UserInterface>();

IServiceProvider serviceProvider = collection.BuildServiceProvider();

//IDataAccess da = new DataAccessMySql();
//IBusiness bs = new Business(da);
UserInterface ui = serviceProvider.GetService<UserInterface>();
ui.SignUp();
Console.ReadKey();



public class UserInterface
{
    private string _username;
    private string _password;

    private readonly IBusiness _business;
    public UserInterface(IBusiness business)
    {
        //_business = new Business();
        _business = business;
    }
    private void GetData()
    {
        Console.WriteLine("Enter Username:");
        _username = Console.ReadLine();

        Console.WriteLine("Enter Password");
        _password = Console.ReadLine();


    }

    public void SignUp()
    {
        GetData();

        //  var biz = new Business();
        _business.SignUp(_username, _password);
    }
}

public interface IBusiness
{
    void SignUp(string username, string password);
}

public class Business : IBusiness
{
    private readonly IDataAccess _dataAccess;
    public Business(IDataAccess dataAccess)
    {
        _dataAccess = dataAccess;
    }

    public void SignUp(string userName, string passWord)
    {
        //var da = new DataAccessSql();
        _dataAccess.SignUp(userName, passWord);
    }

}

public interface IDataAccess
{
    void SignUp(string userName, string passWord);
}

public class DataAccessSql : IDataAccess
{
    public void SignUp(string userName, string passWord)
    {
        Console.Write($"Data has been saved to SQL with username {userName} password {passWord}");
    }
}
public class DataAccessMySql : IDataAccess
{
    public void SignUp(string userName, string passWord)
    {
        Console.Write($"Data has been saved to MySQL with username {userName} password {passWord}");
    }
}
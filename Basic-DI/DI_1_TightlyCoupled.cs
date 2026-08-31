UserInterface UserInterface = new UserInterface();
UserInterface.SignUp();
Console.ReadKey();
public class UserInterface
{
    private string _username;
    private string _password;

    public void GetData()
    {
        Console.WriteLine("Enter Username:");
        _username = Console.ReadLine();

        Console.WriteLine("Enter Password");
        _password = Console.ReadLine();


    }

    public void SignUp()
    {
        GetData();

        var biz = new Business();
        biz.SignUp(_username, _password);
    }
}

public class Business
{
    public void SignUp(string userName, string passWord)
    {
        var da = new DataAccessSql();
        da.SignUp(userName, passWord);
    }

}

public class DataAccessSql
{
    public void SignUp(string userName, string passWord)
    {
        Console.Write($"Data has been saved to SQL with username {userName} password {passWord}");
    }
}
public class DataAccessMySql
{
    public void SignUp(string userName, string passWord)
    {
        Console.Write($"Data has been saved to MySQL with username {userName} password {passWord}");
    }
}
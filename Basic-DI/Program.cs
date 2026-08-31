UserInterface UserInterface = new UserInterface();
UserInterface.GetData();
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

        Console.ReadKey();
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
        Console.Write($"Suppose here. Data has been saved to DB with username {userName} password {passWord}");
    }
}
public class DataAccessMySql
{
    public void SignUp(string userName, string passWord)
    {

    }
}
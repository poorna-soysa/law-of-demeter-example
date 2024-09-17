namespace LawOfDemeterExample;
public class Database
{
    private readonly Connection _connection;
    public Database()
    {
        _connection = new Connection(); 
    }

    public void OpenConnection()
    {
        _connection.Open();
    }
}

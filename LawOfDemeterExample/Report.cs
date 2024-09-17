namespace LawOfDemeterExample;
public class Report
{
    private readonly Database _database;
    public Report()
    {
        _database = new();
    }
    public void OpenConnection()
    {
        _database.OpenConnection();
    }
}

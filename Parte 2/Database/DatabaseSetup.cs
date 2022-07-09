using Microsoft.Data.Sqlite;

namespace Avaliacao3BimLp3.Database;

class DatabaseSetup
{
    private DatabaseConfig databaseConfig;

    public DatabaseSetup(DatabaseConfig databaseConfig)
    {
        this.databaseConfig = databaseConfig;
        CreateStudentTable();
    }
    public void CreateStudentTable()
    {
        var connection = new SqliteConnection("Data Source=database.db");
        connection.Open();

        var command = connection.CreateCommand();
        command.CommandText = @" 
        CREAT TABLE IF NOT EXIST Student (
        id int not null primary key , 
        name varchar(100) not null,
        city varchar(100) not null , 
        former varchar(100) not null 
        );
        ";

        command.ExecuteNonQuery();


        connection.Close();
    }
}
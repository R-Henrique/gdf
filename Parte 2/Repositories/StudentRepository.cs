using Avaliacao3BimLp3.Database;
using Avaliacao3BimLp3.Models;
using Microsoft.Data.Sqlite;
using Dapper;

namespace Avaliacao3BimLp3.Repositories;

class StudentRepository
{
    private DatabaseConfig databaseConfig ; 

    public StudentRepository(DatabaseConfig databaseConfig)
    {
        this.databaseConfig = databaseConfig;
    }
}
        public IEnumberable<Student> GetAll()
        {
            using var connection = new SqliteConnection(databaseConfig.ConnectionString);
            connection.Open();

            var student = connection.Query<Student>("SELECT * FROM Student");

            return student ; 
        }

        public Student Save(Student student)
        {
            using var connection = new SqliteConnection(databaseConfig.ConnectionString);
            connection.Open();

            connection.Execute("INSERT INTO Students VALUES(@Id, @Name, @City, @Former);", student);

        return student;
        }
        public bool ExistById(int id)
        {
            using var connection = new SqliteConnection(databaseConfig.ConnectionString);

             
        }
        public bool ExistById(int id )
        {
            using var connection = new SqliteConnection(databaseConfig.ConnectionString);
            connection.Open();

            var result = connection.ExecuteScalar<bool>("SELECT count(id) Students WHERE Id = @Id", new {Id = id});
        }
         public void Delete(int id )
         {
            using var connection = new SqliteConnection(databaseConfig.ConnectionString);
            connection.Open();

            connection.Execute("DELETE FROM Students WHERE Id = @Id", new {Id = id});

         }

         public void MarkASFormed(int id )
         {
            using var connection = new SqliteConnection(databaseConfig.ConnectionString);
            connection.Open();
            
           
         }
    
         public List<Student>GetAllFormed(bool former)
         {
           using var connection = new SqliteConnection(databaseConfig.ConnectionString);
            connection.Open();

            var students = connection.Query<Student>("SELECT * FROM Students WHERE former = @Former ", new {Former = former}).ToList();
            return students;

            
         }
         public List<Student>GetAllStudentByCity(string city)
         {
            using var connection = new SqliteConnection(databaseConfig.ConnectionString);
            connection.Open();

            var students = connection.

         }
         public List<Students> GetAllByCitties(string[] citties)
         {
            using var connection = new SqliteConnection(databaseConfig.ConnectionString);
            connection.Open();

         }
         public List<CountStudentGroupByAttribute> CountByCitties()
         {
            using var connection = new SqliteConnection(databaseConfig.ConnectionString);
            connection.Open();
         }
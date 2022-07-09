using Avaliacao3BimLp3.Database;
using Avaliacao3BimLp3.Models;
using Avaliacao3BimLp3.Repositories;
using Microsoft.Data.Sqlite;


var databaseConfig = new DatabaseConfig();
var DatabaseSetup = new DatabaseSetup(databaseConfig);

var studentRespository = new StudentRepository(databaseConfig);

var modelName = args[0];
var modelAction = args [1];

if(modelName == "Student")
{
    if(modelAction == "List")
    {
        if(studentRespository.GetAll().Count() != 0 ){
            foreach(var student in studentRespository.GetAll())
            {
                Console.WriteLine("{0} , {1} , {2}, {3}", student.Id, student.Name, student.City, student.Former);
            }
        }
    }
    else
    {
        Console.WriteLine("Nenhum aluno registrato");
    }
}
if(modelAction == "New")
{
    int id  = Convert.ToInt32(args[2]);
    string name = args [3];
    string city = args [4];
    bool former = args [5];

    if(studentRespository.ExistById(id))
    {
        Console.WriteLine($"Estudente com id {id} já existe!");
    }
}
if(modelAction == "Formed")
{
    bool former = args[2];
    
    if(studentRespository.GetAllFormed(former).Count() != 0 )
    {
        foreach(var student in studentRespository.GetAllFormed(former))
        {
            Console.WriteLine("{0}, {1}, {2}, {3}" , student.Id , student.Name , student.City , student.Former);

        }
        else
        {
            Console.WriteLine($"Nenhum estudante encontrado {former}");

        }
    }
}

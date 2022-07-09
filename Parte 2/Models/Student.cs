namespace Avaliacao3BimLp3.Models;

class Student 
{
    public int Id  { get; set; }
    public string Name { get; set; }
    public string City { get; set; }
    public bool Former { get; set;}
}

class CountStudentGroupByAttribute 
{
    public string AttributeName {get; set;}
    public int StudentNumber { get; set;}
}

public Student( ) {}
 
  
public Student(int id  , string name , string city , bool former)
{
    Id = id ;
    Name = name ;
    City = city;
    Former = former;

}
namespace OOP_excerise_full.lession_9 ;

public class Student
{
    public string  Name { get ; set ; }
    public int Age  { get ; set ; }
    public double Math { get ; set ; }
    public double Lit { get ; set ; }


    public Student ( string name , int age , double math , double lit )
    {
        Name = name ;
        Age = age ;
        Math = math ;
        Lit = lit ;
        
    }
    
}
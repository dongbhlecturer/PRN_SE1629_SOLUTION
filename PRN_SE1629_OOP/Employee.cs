namespace PRN.SE1629;
public class Employee:Person //IS-A
{
    /*fields/data*/
    private int _id;
   
    /*properties*/
    //init auto - properties
    public double Salary { get; init; } //.NET 6 +
    public int Id { get => _id; set => _id = value; }
   
    public  string NameOfCompany { get; } = "FPT Education";

    /*constructors no param*/
    public Employee()
    {
        
    }
    /*constructor with params*/
    public Employee( int id,  string name, double salary,DateOnly dob, Address address):base(name,dob,address)
    {
        this._id = id;
        this.Salary = salary;

    }

    public override string? ToString()
    {
        return $"[Id = {this._id}, Name = {this.Name}, Salary = {Salary}], Address = {Address}";
    }
}
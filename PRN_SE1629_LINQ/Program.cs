using System.Linq;
using Prn.Se1629;
string[] names = { "dong", "hai", "long", "Nguyen Van C", "Pack Hang Seo", "Cong Phuong","abc"};

var orderedNames = names.OrderBy(s => s.Length);

foreach (var name in orderedNames)
{
    Console.WriteLine(name);
}
Console.WriteLine("====================");
SortedSet<string> sorted = new SortedSet<string>(names);
foreach (var name in sorted)
{
    Console.WriteLine(name);
}


foreach (var a in names.Select(s => s.Contains("a")))
{
    Console.WriteLine(a);
}

var items = from w in names
            where w.Length > 4
            select w;

foreach (var item in items)
{
    Console.WriteLine(item);
}
Console.WriteLine("====================");
foreach (var a in names.Where(n=>n.Length>4))
{
    Console.WriteLine(a);
}


int[] numbers = { 1, 2, 3 };
numbers.Sum(n => n );
Console.WriteLine(numbers.Sum(n => n));

//Define 1 tap hop cac Student
List<Student> students = new List<Student>();
students.Add(new Student(1, 5.5d));
students.Add(new Student(2, 5.5d));
students.Add(new Student(3, 9.5d));
students.Add(new Student(4, 2.5d));
students.Add(new Student(5, 7.5d));


var data = students.OrderBy(s => s.Mark);
foreach(var item in data)
{
    Console.WriteLine(item);
}


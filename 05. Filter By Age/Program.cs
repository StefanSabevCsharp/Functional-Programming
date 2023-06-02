using System.Threading.Channels;

int n = int.Parse(Console.ReadLine());
List<Person> people = new List<Person>();
for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split(", ");
    string name = input[0];
    int ageOfPerson = int.Parse(input[1]);
    Person person = new Person(name,ageOfPerson);
    people.Add(person);
}
string condition = Console.ReadLine();
int age = int.Parse(Console.ReadLine());
string format = Console.ReadLine();

Func<Person, bool> CreateFilter(string condition, int age)
{

    if (condition == "younger")
    {
        return x => x.Age < age;
    }
    else
    {
        return x => x.Age >= age;
    }
}
Action<Person> printer = CreatePrinter(format);

Action<Person> CreatePrinter(string format)
{
    switch (format)
    {
        case "name age": return p => Console.WriteLine($"{p.Name} - {p.Age}");
            case "name": return p => Console.WriteLine($"{p.Name}");
            case "age": return p => Console.WriteLine($"{p.Age}");
            default:
            return null;
    }
}

Func<Person, bool> filter = CreateFilter(condition, age);
people = people.Where(filter).ToList();

foreach (var person in people)
{
    printer(person);
}


class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public Person(string name,int age)
    {
        Name= name;
        Age = age;
    }

}



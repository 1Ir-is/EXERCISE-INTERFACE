public interface IBirthable
{
    string Birthdate { get; }
}

public interface IIdentifiable
{
    string Id { get; }
}

public interface IPerson
{
    string Name { get; }

    int Age { get; }
}
public class Citizen : IPerson, IBirthable, IIdentifiable
{
    public Citizen(string name, int age, string id, string birthDate)
    {
        this.Name = name;
        this.Age = age;
        this.Id = id;
        this.Birthdate = birthDate;
    }
    public string Name { get; private set; }

    public int Age { get; private set; }

    public string Birthdate { get; private set; }

    public string Id { get; private set; }
}
internal class Program
{
    private static void Main(string[] args)
    {
        string name = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());
        string id = Console.ReadLine();
        string birthdate = Console.ReadLine();
        IIdentifiable identifiable = new Citizen(name, age, id, birthdate);
        IBirthable birthable = new Citizen(name, age, id, birthdate);
        Console.WriteLine(identifiable.Id);
        Console.WriteLine(birthable.Birthdate);
    }
}


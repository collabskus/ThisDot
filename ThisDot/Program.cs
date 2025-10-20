public class Program
{
    public static void Main()
    {
        string name = "Kushal";
        Person person = new Person(name);
        string greeting = person.Greet();
        Console.WriteLine(greeting);
    }
}

public class Person
{
    private string name;
    public Person(string name)
    {
        // using name = name is incorrect here 
        // because it is not clear which name we are talking about 
        // so we use this dot here 
        // name = name;	
        this.name = name;
    }
    public string Greet()
    {
        return "Namaste " + name;
    }
}
// Output: Namaste Kushal
// Explanation: In this example, we have a Person class with a constructor that takes a name parameter.
// Inside the constructor, we use this.name to refer to the instance variable name,
// distinguishing it from the parameter name. This ensures that the instance variable is correctly assigned the value passed to the constructor.

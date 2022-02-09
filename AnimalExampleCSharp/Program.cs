namespace AnimalExampleCSharp;
public class program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Bat myBat = new Bat();

        Console.WriteLine(myBat.ToString());
        Console.WriteLine(myBat.Age);
        Console.WriteLine(myBat.poo());
    }
}

// See https://aka.ms/new-console-template for more information
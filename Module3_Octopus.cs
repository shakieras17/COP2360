using System;

class Octopus
{
    public string Name;
    public int Age = 10;
    public readonly int Legs = 8;
}

class Program
{
    static void Main()
    {
        Octopus myOctopus = new Octopus();

        myOctopus.Name = "Jack";

        Console.WriteLine("Octopus Name: " + myOctopus.Name);
        Console.WriteLine("Age: " + myOctopus.Age);
        Console.WriteLine("Legs: " + myOctopus.Legs);
    }
}

// Animal.cs
using System;

public class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Animal Name: {Name}, Age: {Age}");
    }
}

public class Dog : Animal
{
    public Dog(string name, int age) : base(name, age) { }

    public void Bark()
    {
        Console.WriteLine($"{Name} says: Woof!");
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("This is a dog.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Dog myDog = new Dog("Buddy", 3);
        myDog.DisplayInfo();
        myDog.Bark();
    }
}

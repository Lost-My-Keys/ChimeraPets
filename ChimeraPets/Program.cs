using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace CreateAnimal;
//Testing 
class Animal
{
    string name;
    string? color;
    string? DTrait1;
    string? DTrait2;
    string? STrait1;
    string? STrait2;
    static void Main(string[] args)
    {
        
        Animal animal1 = new Animal("Lion", null, "Happy", "big claws");

        animal1.DisplayInfo();

    }


    public Animal(string name, string? color = null, string? DTrait1 = null, string? DTrait2 = null, string? STrait1 = null, string? STrait2 = null)
    {
        this.name = name;
        this.color = color;
        this.DTrait1 = DTrait1;
        this.DTrait2 = DTrait2;
        this.STrait1 = STrait1;
        this.STrait2 = STrait2;

        
    }
    public void DisplayInfo()
    {
        
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Traits: {DTrait1 ?? ""} {DTrait2 ?? ""} {STrait1 ?? ""} {STrait2 ?? ""}");
        Console.WriteLine($"Color: {color ?? ""}");
    }
}
using System.Diagnostics;

namespace oop_classes_example;

class Program
{
    static void Main(string[] args)
    {
        Person person = new("Cade Foster"){Age=35};
        person.Relocate("Fiji");
        float distance = person.GetDistance("Toronto");
        Console.WriteLine($"Distance is {distance}");
    }
}

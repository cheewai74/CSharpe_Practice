namespace oop_classes_record_example;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Animals.Dog rex = new ("Rex", "Schnauzer", 40, 11,5);

        Console.WriteLine($"Dog Breed {rex}");

        Animals.Cat maggie = new () 
        { 
            Name = "Magpie", 
            Breed = "Persian", 
            Height = 30, 
            Weight = 10, 
            Age = 14 
        };
        Console.WriteLine($"Cat Breed {maggie}");

        Animals.Cat beauty = maggie with {Name = "Beauty", Height = 35};
        Console.WriteLine($"Cat Breed {beauty}");
    }
}
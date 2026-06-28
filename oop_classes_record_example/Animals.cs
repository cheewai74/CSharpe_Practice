namespace oop_classes_record_example;

public class Animals
{
    public record Dog(string Name, string Breed, int Height, float Weight, int Age);

    public record Cat
    {
        public required string Name{get; set;}
        public required string Breed{get; set;}
        public required int Height{get; set;}
        public required float Weight{get; set;}
        public required int Age{get; set;}
    }
}

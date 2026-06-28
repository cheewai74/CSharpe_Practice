namespace oop_classes_example;

public class Person
{
    private string _location = String.Empty;


    public string Name {get; set;}

    public required int Age{get; set;}

    public Person() => Name = "---";

    public Person(string name)
    {
        Name = name;
    }

    public void Relocate(string location)
    {
        if (!string.IsNullOrEmpty(location))
        {
            _location = location;
        }
    }

    public float GetDistance(string location)
        => DistanceHelpers.GetDistance(_location, location);
}

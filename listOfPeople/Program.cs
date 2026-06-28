namespace listOfPeople;

class Program
{
    static void Main(string[] args)
    {
        List<Person> people =
        [
        new("Marcin", 35, "PL"),
        new("Sabine", 25, "DE"),
        new("Mark", 31, "PL")
        ];

        List<Person> r = [.. people.OrderBy(p => p.Name)];
        foreach (Person p in r)
        {
            string line = $"{p.Name} ({p.Age}) from {p.Country}.";
            Console.WriteLine(line);
        }
    }
}

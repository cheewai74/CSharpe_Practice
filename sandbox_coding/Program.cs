namespace sandbox_coding;

class Program
{
    static void Main(string[] args)
    {
        double sum = 0;
        Console.Write("n = ");
        int.TryParse(Console.ReadLine(), out int n);
        if(n == 0){Console.WriteLine("No result.");}
        Console.WriteLine("Hello, World!");

        int i = 0;
        do
        {
            Console.Write(" a = ");
            double.TryParse(Console.ReadLine(), out double a);
            sum += a;
            i++;
        }
        while(i != n);

        double result = sum /n;
        Console.WriteLine($"Result: {result:F2}");

    }
}

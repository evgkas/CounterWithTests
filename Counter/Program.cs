namespace CounterProject
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("String:");
            string line = Console.ReadLine();
            Counter counter = new();
            Console.WriteLine($"Letter counter = {counter.IdenticalLetters(line)}");
            Console.WriteLine($"Number counter = {counter.IdenticalNumbers(line)}");
            Console.WriteLine($"DifferentSymbols counter = {counter.DifferentSymbols(line)}");
        }
    }
}


namespace Zebra.Bets;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("[1] for Home Team...");
        Console.WriteLine("[2] for Visitor Team...");

        var team = int.Parse(Console.ReadLine()?.TrimEnd('\r', '\n'));
        
    }
}

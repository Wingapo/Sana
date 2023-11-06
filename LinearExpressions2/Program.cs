// See https://aka.ms/new-console-template for more information

namespace LinearExpressions2;

internal class Program {
    public static void Main(string[] args) {
        
        double m, n, x, a, b;
        
        Console.Write("a = ");
        if (!Double.TryParse(Console.ReadLine(), out a)) return;
        Console.Write("b = ");
        if (!Double.TryParse(Console.ReadLine(), out b)) return;
        Console.Write("m = ");
        if (!Double.TryParse(Console.ReadLine(), out m)) return;
        Console.Write("n = ");
        if (!Double.TryParse(Console.ReadLine(), out n)) return;
        Console.Write("x = ");
        if (!Double.TryParse(Console.ReadLine(), out x)) return;

        double z1 = ((m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n)) /
                    (Math.Sqrt(Math.Pow(m, 3) * n) + m * n + Math.Pow(m, 2) - m);
        double z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;
        double y = 2.4 * Math.Abs((Math.Pow(x, 2) + b) / a) + (a - b) * Math.Pow(Math.Sin(a - b), 2) +
                   Math.Pow(10, -2) * (x - b);
        
        Console.WriteLine($"z1 = {z1:F2}; z2 = {z2:F2}; y = {y:F2}");
    }
}
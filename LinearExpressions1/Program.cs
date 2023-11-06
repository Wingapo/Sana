// See https://aka.ms/new-console-template for more information

namespace LinearExpressions1;

internal class Program {
    public static void Main(string[] args) {

        double a, b, c, d;
        
        Console.Write("a = ");
        if (!Double.TryParse(Console.ReadLine(), out a)) return;
        Console.Write("b = ");
        if (!Double.TryParse(Console.ReadLine(), out b)) return;
        Console.Write("c = ");
        if (!Double.TryParse(Console.ReadLine(), out c)) return;
        Console.Write("d = ");
        if (!Double.TryParse(Console.ReadLine(), out d)) return;
        
        double x = (a + 2 * b - c + d) / (c * d) + (a + b) / (c - d) - Math.Pow(a / b, 2);
        double y = 5 * (a + b) * (c - d) / (1.0 / 2 * c) + Math.Pow(d, 2) * (Math.Pow(a, 2) - Math.Pow(b, 2)) / (b - a);
        double z = (Math.Pow(Math.Pow(x, 2) - 2 * x, 3) - 4 * (Math.Pow(x, 4) + 1)) * (1 - b) / (5 * a + 3 * b);
        double r = (1.0 / 2 * a + 3.0 / 4 * b - 7.0 / 5) / (3 * c + 1) + 1 / (a - c);
        
        Console.WriteLine($"x = {x:F2}; y = {y:F2}; z = {z:F2}; r = {r:F2}");
    }
}
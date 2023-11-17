// Сушинський Ігор
// Лабораторна робота № 3
// Оголошення та будова класу.
// Варіант 3

namespace LAB3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Fraction f = new();
            f.Read();
            f.Display();
            Console.WriteLine("--------------------");
            f.Simplify();
            f.Display();
        }
    }
}
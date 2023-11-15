using System;
class Program
{
    static void Main()
    {
        double x, b, a;
        Console.Write("Введите значение a: ");
        a = double.Parse(Console.ReadLine());
        Console.Write("Введите значение b: ");
        b = double.Parse(Console.ReadLine());
        if (a > b)
            x = a * b - 3;
        else if (a == b)
            x = 2;
        else
            x = (Math.Pow(a, 3) + 1) / b;
        Console.WriteLine("Результат: " + x);
        Console.ReadKey();
    }
}
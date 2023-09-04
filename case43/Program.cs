/* Задача 43: Напишите программу, 
которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

double InputNum (string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

double FindX(double a, double b, double c, double d)
{
    double numberX = (c - a) / (b - d);
    return numberX;
}

double FindY(double e, double f, double g)
{
    double numberY = f * g + e;
    return numberY; 
}

void PrintResult(double h, double i, double j, double k, double l, double m)
{
    if (i == k)
    {
        if (h == j)
            Console.WriteLine("Прямые совпадают");
        else 
            Console.WriteLine("Прямые параллельны");
    }
    else
    Console.WriteLine($"Точка пересечения двух прямых: ({l}; {m})");
}

double b1 = InputNum("Введите значение b1: ");
double k1 = InputNum("Введите значение k1: ");
double b2 = InputNum("Введите значение b2: ");
double k2 = InputNum("Введите значение k2: ");
double x = Math.Round(FindX(b1, k1, b2, k2), 1);
double y = Math.Round(FindY(b1, k1, x), 1);
PrintResult(b1, k1, b2, k2, x, y);
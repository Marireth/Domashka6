/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

int GetNumberUser(string NumberUser)
{
    int result = 0;
    Console.Write(NumberUser);
    result = Convert.ToInt32(Console.ReadLine());
    return result;
}

double InterSectionPoint(double b1, double k1, double b2, double k2)
{
    double x = 0;
    double y = 0;
    x = (b2 - b1) / (k1 - k2);
    y = k1 * x + b1;
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine($"Точка пересечения двух прямых имеет следующие координаты: ({x};{y})");
    Console.ResetColor();
    return x;
}
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine();
Console.WriteLine("Уравнение y = k1 * x + b1");
Console.ResetColor();
int b1 = GetNumberUser("Введите значение b1: ");
int k1 = GetNumberUser("Введите значение k1: ");
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine();
Console.WriteLine("Уравнение y = k2 * x + b2");
Console.ResetColor();
int b2 = GetNumberUser("Введите значение b2: ");
int k2 = GetNumberUser("Введите значение k2: ");
Console.WriteLine();

double result = InterSectionPoint(b1, k1, b2, k2);
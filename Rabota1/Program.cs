// // Задача 43: Напишите программу, 
// которая найдёт точку пересечения двух прямых,
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// // b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введите b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

double Xpoint(double bb1, double kk1, double bb2, double kk2)
{
    double xx = -(bb1 - bb2) / (kk1 - kk2);
    xx = Math.Round(xx, 1);
    return xx;
}

double Ypoint(double kk1, double bb1, double xx)
{
    double yy = kk1 * xx + bb1;
    yy = Math.Round(yy, 1);
    return yy;
}

double x = Xpoint(b1, k1, b2, k2);
double y = Ypoint(k1, b1, x);
x = Math.Round(x, 1);
y = Math.Round(y, 1);

Console.WriteLine($"Пересечение в точке: ({x};{y})");
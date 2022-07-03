// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84.
//A (7,-5, 0); B (1,-1,9) -> 11.53.

Console.Write("Введите X1: ");
double X1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите Y1: ");
double Y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите Z1: ");
double Z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите X2: ");
double X2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите Y2: ");
double Y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите Z2: ");
double Z2 = Convert.ToDouble(Console.ReadLine());
double R = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2) +Math.Pow(Z1 -Z2, 2));
Console.WriteLine("R = {0}", R);

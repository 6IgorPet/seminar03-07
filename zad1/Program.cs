// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Clear();
System.Console.WriteLine("Введите пятизначное число");
string number = Console.ReadLine()!;
int length = number.Length;
if (length == 5)
{
     if (number.Reverse().SequenceEqual(number)) Console.WriteLine($"Число {number} является палиндромом"); 
     // реверс переворачивает число,секьенсеквал сравнивает
     else System.Console.WriteLine($"Число {number} не является палиндромом ");
}
else System.Console.WriteLine($"Error. Введите пятизначное число");

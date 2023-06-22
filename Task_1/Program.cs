// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт максимальное число

Console.Write("Введите число 1: ");
int num1 = Convert.ToInt32( Console.ReadLine() );

Console.Write("Введите число 2: ");
int num2 = Convert.ToInt32( Console.ReadLine() );

Console.WriteLine("Максимальное число: " + Math.Max(num1, num2));
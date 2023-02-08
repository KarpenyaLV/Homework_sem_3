// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// System.Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num / 10000 == num % 10 && num / 1000 % 10 == num % 10000 / 1000)
// {
//     System.Console.WriteLine("Число является палиндромом");
// }
// else
// {
//     System.Console.WriteLine("Число не является палиндромом");
// }

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// int InputNumber(string str)
// {     
//     System.Console.WriteLine(str); 
//     return Convert.ToInt32(Console.ReadLine());
// }  
// int x1 = InputNumber("Введите координату Х1: ");
// int y1 = InputNumber("Введите координату Y1: ");
// int z1 = InputNumber("Введите координату Z1: ");
// int x2 = InputNumber("Введите координату X2: ");
// int y2 = InputNumber("Введите координату Y2: ");
// int z2 = InputNumber("Введите координату Z2: ");

// int A = x2 - x1;
// int B = y2 - y1;
// int C = z1 - z2;

// double length = Math.Sqrt(A * A + B * B + C * C);
// Console.WriteLine($"Длинна отрезка {length}");



// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// int number = ReadInt("Введите число N: ");

// for (int i = 1; i <= number; i++)
// { 
//     Console.Write($"{i*i*i} ");
// }

// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Ваше число: " + number);
int firstNum = number / 100;
int secondNum = (number / 10) % 10;
int thirdNum = number % 10;
Console.WriteLine("Вторая цифра: " + secondNum);



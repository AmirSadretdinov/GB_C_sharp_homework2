// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1
int searchSecondNum(int arg){
    int result = (arg / 10) % 10;
    return result;
}
Console.WriteLine("Введите трехзначное число");
int input = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Ваше число: " + input);
int result = searchSecondNum(input);
System.Console.WriteLine("Вторая цифра: " + result);



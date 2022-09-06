// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число");
string number = Console.ReadLine();
Console.WriteLine("Ваше число: " + number);
int num = Convert.ToInt32(number); // Преобразование строки в число для мат операций
int a = number.Length;
if (a > 3 || a == 3){
    while (a > 3)
    {
      num = num / 10;
      a--;  
    }  
    int thirdNum = num % 10;
    Console.WriteLine("Третья цифра: " + thirdNum);
}
else if (a < 3){
    Console.WriteLine("Третьей цифры нет");
}

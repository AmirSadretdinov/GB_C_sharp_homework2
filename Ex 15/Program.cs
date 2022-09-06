// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите порядковый номер дня недели");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Вы ввели: " + number);
if ( number == 6 || number == 7){
    System.Console.WriteLine("Этот день являеся выходным");
}
if (number > 0 && number < 6){
    System.Console.WriteLine("Этот день не являеся выходным");
}
else if (number == 0 || number > 8 || number < 0) {
    System.Console.WriteLine("Нет дня недели с таким номером");
}


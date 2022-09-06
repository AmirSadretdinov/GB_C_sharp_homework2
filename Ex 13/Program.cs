// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
string searchThirdNum(string arg){
  int num = Convert.ToInt32(arg); 
  int a = arg.Length;
if (a > 3 || a == 3){
    while (a > 3)
    {
      num = num / 10;
      a--;  
    }  
    int search = num % 10;
    string thirdNum = Convert.ToString(search);
    return thirdNum;
}
return null;
}
Console.WriteLine("Введите число");
string input = Console.ReadLine();
System.Console.WriteLine("Ваше число: " + input);
string number = searchThirdNum(input);
if (number == null){
  System.Console.WriteLine("Третьей цифры нет");
}
else {
  System.Console.WriteLine("Третья цифра: " + number);
}


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

bool proverkaDate(int arg){
    if ( arg == 6 || arg == 7){
    return true;
    }
    else{
    return false;
    }
}

Console.WriteLine("Введите порядковый номер дня недели");
int input = Convert.ToInt32(Console.ReadLine());
bool number = proverkaDate(input);
if (number == true){
    System.Console.WriteLine("да");
}
else {
    System.Console.WriteLine("нет");
}



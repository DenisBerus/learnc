/*
Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/
// Вариант 1 решения 18.12.22:
/*
int num = 1;
int cur = 0;
int curbol = 0;
int cur1 = 0;
while (cur <= num)
{
    Console.Write("Напишите число: ");
    cur1 = Convert.ToInt32(Console.ReadLine());
    if(cur1 > 0) curbol += 1;
    Console.WriteLine($"Чисел больше нуля: {curbol}.");
    Console.WriteLine($"Для завершения программы нажмите CTRL+C");
    cur += 1;
    num += 1;
}
*/
// Вариант 2 решения 20.12.22:
/*
int InputDate(){
    Console.Write("Введите кол-во число: ");
    int date = Convert.ToInt32(Console.ReadLine());
    return date;
}
int printDate(int date){
    int i = 0;
    int count = 0;
    while(date > i)
    {
        int numb = new Random().Next(-1000, 1000);
        Console.Write(numb + " ");
        i++;
        if(numb > 0) count += 1;
    }
    return count;
}
int dateA = InputDate();
int datesCount = printDate(dateA);
Console.WriteLine($"Чисел больше нуля: {datesCount}.");
*/

// Вариант 3 решения После семинара 23.12.22:
/*
int NumberPosition(int num){
    int count = 0;
    for(int current = 0; current < num; current++){
        Console.Write("Введите число:");
        int sum = Convert.ToInt32(Console.ReadLine());
        if(sum > 0) count++;
    }
    return count;
}
Console.Write("Какое кол-во цифор введете: ");
int b11 = Convert.ToInt32(Console.ReadLine());
int cont = NumberPosition(b11);
Console.WriteLine();
Console.WriteLine($"Введено чисел больше нуля: {cont}");
*/

/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
/*
void CrossPoint(double b1, double k1, double b2, double k2){
    double x = (b2-b1)/(k1-k2);
    double y = k1 * x + b1;  
        Console.WriteLine($"Ответ y={y} и x={x}");
}

Console.Write("Напишите число из любых цифр b1: ");
double b11 = Convert.ToDouble(Console.ReadLine());
Console.Write("Напишите число из любых цифр k1: ");
double k11 = Convert.ToDouble(Console.ReadLine());
Console.Write("Напишите число из любых цифр b2: ");
double b22 = Convert.ToDouble(Console.ReadLine());
Console.Write("Напишите число из любых цифр k2: ");
double k22 = Convert.ToDouble(Console.ReadLine());

CrossPoint(b11, k11, b22, k22);
*/
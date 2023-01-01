
/* ДЗ 9 Задача 1
Задача 64: Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

/*  // Вариат 1: делал по лекции, до того как посмотрел Семинал (к сожалению пропустил в воскр)
int Rec(int num){
    if(num == 1) return 1;
    else{
    int count = num;
    Console.Write($"{count}, ");
    return Rec(num - 1);
    }
}
Console.Write("Введите любое натуральное число ");
int num = Convert.ToInt32(Console.ReadLine());
int result = Rec(num);
Console.WriteLine(result);
*/

/* // Вариант 2: по итогам просмотра Семината
void Count(int num){
    Console.Write(num + " ");
    if(num > 1) Count(num - 1);
}
Console.Write("Введите любое натуральное число ");
int num = Convert.ToInt32(Console.ReadLine());
Count(num);
Console.WriteLine(Count);
*/


/* ДЗ 9 Задача 2
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке
 от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

/*
int Result(int num1, int num2){
    int sum = num1;
    if(num1 == num2) return sum;
    else return sum + Result(num1 + 1, num2); 
}

Console.Write("Введите любое Первое  натуральное число ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите любое Второе натуральное число ");
int m = Convert.ToInt32(Console.ReadLine());
int result = Result(n, m);
Console.WriteLine(result);
*/

/* LP 9 Задача 3
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

/*
double Accerman(double n, double m){
  if(n == 0) return m + 1;
  else{
    if((n != 0) && (m == 0)) return Accerman(n - 1, 1);
    else return Accerman(n - 1, Accerman(n, m - 1));
    }
}

Console.Write("Введите любое натуральное число ");
double nn = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите любое натуральное число ");
double mm = Convert.ToInt32(Console.ReadLine());
double resulting = Accerman(nn, mm);
Console.WriteLine(resulting);
*/








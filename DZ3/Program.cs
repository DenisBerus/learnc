/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
/*
int Palindrome(int Num) {
    int cur = 0;
    int xxx = Num;
    while(xxx > 0) {
        int curA = cur * 10; 
        int curB = xxx % 10;
        cur = curA + curB;
        xxx /= 10;
    }
    return cur;
}

void PrintOtvet(int otvet1, int N1) {
    if (otvet1 == N1) Console.WriteLine("Палиндром");   
    else Console.WriteLine("Не палиндром");
}

Console.Write("Напишите целое число: ");
int N = Convert.ToInt32(Console.ReadLine());
int otvet = Palindrome(N);
PrintOtvet(otvet, N);
*/

/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
/*
double Dist(double xa, double ya, double za, double xb, double yb, double zb)
{
    double result = Math.Pow(xb-xa, 2) + Math.Pow(yb-ya, 2) + Math.Pow(zb-za, 2);
    double fin = Math.Sqrt(result);
    return Math.Round(fin, 2);
}
Console.Write("Введите X координаты A: ");
double xxa = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите Y координаты A: ");
double yya = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите Z координаты A: ");
double zza = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите X координаты B: ");
double xxb = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите Y координаты B: ");
double yyb = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите Z координаты B: ");
double zzb = Convert.ToDouble(Console.ReadLine());

double otvet = Dist(xxa, yya, zza, xxb, yyb, zzb);
Console.WriteLine($"расстояние между равно = {otvet}");
*/



/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
/*
void Sumquad(int num)
    {
        int cur = 1;
        if(num < 1) Console.WriteLine("Измените число! Возможные числа от 1 и больше.");
        while(num >= cur)
            {
                int result = cur * cur * cur;
                Console.Write($"число {cur} для него куб: ");
                Console.WriteLine(result);
                cur++;
            }
    }
Console.Write("Напишите число: ");
int numA = Convert.ToInt32(Console.ReadLine());
Sumquad(numA);
*/
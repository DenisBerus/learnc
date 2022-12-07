// Задача 1
/*
void Vtoroy(int num)
    {
        int num2 = num / 10;
        int num3 = num2 % 10;
        Console.WriteLine(num3);
    }
Console.Write("Напишите число из 3х цифр: ");
int numA = Convert.ToInt32(Console.ReadLine());
Vtoroy(numA);
*/


// Задача 2
/*
void Videlit(int num)
    {
       if(num > 99)
        {
            while(num > 999)
                {
                    int cur = 10;
                    num = num / cur;
                    cur = cur * 10;
                }
            int result = num % 10;
            Console.WriteLine($"Третье число {result}");
        }
        if(num <100)
            {
                Console.WriteLine("нет третьей цифры");
            }
    }
Console.Write("Напишите число: ");
int numA = Convert.ToInt32(Console.ReadLine());
Videlit(numA);
*/

// Задача 3
/*
void Week(int num)
{
    if(num == 6 || num == 7) Console.WriteLine("Ура! Выходной!");
    else Console.WriteLine("Нет, будни(");
}
Console.Write("Напишите день недели: ");
int numA = Convert.ToInt32(Console.ReadLine());
Week(numA);
*/

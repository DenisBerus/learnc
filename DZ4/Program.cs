/*
Урок 4. Функции
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
/*
int Stepen(int num, int step){

    int result = num;
    int cur = 1;
    while(cur != step){
        result *= num;
        cur++;
    }
    return result;
}
Console.Write("Напишите число: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Напишите степень: ");
int numB = Convert.ToInt32(Console.ReadLine());
int otvet = Stepen(numA, numB);
Console.WriteLine($"Степень {numB} числа {numA} равна = {otvet}");
*/

/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
/*
int Sumnumber(int num){
    int cur = 0;
    int sum = 0;
    while(0 < num)
    {
        cur = num % 10;
        sum += cur;
        num = num / 10;
    }
    return sum;
}
Console.Write("Напишите число: ");
int numA = Convert.ToInt32(Console.ReadLine());
int otvet = Sumnumber(numA);
Console.WriteLine($"число {numA} сумма цифр = {otvet}");
*/

/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/
/*
int[] CreateRandomArray(int size){

    int[] array = new int[size];
    for(int i = 0; i < size; i++){
        array[i] = new Random().Next(0, 33); // в ограничении "33" т.к. в условии максимальное число 33
    }
    return array;
}
void ShowRandomArray(int[] array){
            Console.Write("Выводим все восемь элементы массива: ");
            for(int i = 0; i < array.Length; i++){
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
}
Console.Write("Задайте размер массива: ");
int numA = Convert.ToInt32(Console.ReadLine());
int[] otvet = CreateRandomArray(numA);
ShowRandomArray(otvet);
*/
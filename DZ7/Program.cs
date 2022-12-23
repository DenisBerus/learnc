/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
/*
double[,] CreateRandomArray(int m, int n){
    double[,] array = new double[m,n];
        for(int i = 0; i < m; i++){
            for (int j = 0; j < n; j++){
                array[i,j] = new Random().Next(-10,10);
            }
        }     
        return array;   
}

void ShowRandomArray(double[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            Console.Write(array[i,j] + " ");
        }
    Console.WriteLine();
    }
}

Console.Write("input a number of rows: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("input a number of columns: ");
int numB = Convert.ToInt32(Console.ReadLine());

double[,] otvet = CreateRandomArray(numA,numB);
ShowRandomArray(otvet);
*/



/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1 7 -> числа с такими индексами в массиве нет
*/
/*
int[,] CreateRandomArray(){
    int[,] array = new int[4,4];
        for(int i = 0; i < array.GetLength(0); i++){
            for (int j = 0; j < array.GetLength(1); j++){
                array[i,j] = new Random().Next(0,10);
            }
        }     
        return array;   
}

void ShowRandomArray(int[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            Console.Write(array[i,j] + " ");
        }
    Console.WriteLine();
    }
    Console.WriteLine();
}

void SearchPosition(int[,] array, int i, int j){
    if(i < array.GetLength(0) &&  j < array.GetLength(1)) Console.Write(array[i,j] + " ");
    else Console.Write("такого элемента нет");
    Console.WriteLine();
}

int[,] otvet = CreateRandomArray();
ShowRandomArray(otvet);
Console.Write("Напишите индекс по rows: ");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write("Напишите индекс по columns: ");
int j = Convert.ToInt32(Console.ReadLine());
SearchPosition(otvet, i, j);
*/





/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
/*
int[,] CreateRandomArray(){
    int[,] array = new int[4,4];
        for(int i = 0; i < array.GetLength(0); i++){
            for (int j = 0; j < array.GetLength(1); j++){
                array[i,j] = new Random().Next(0,10);
            }
        }     
        return array;   
}

void ShowRandomArray(int[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            Console.Write(array[i,j] + " ");
        }
    Console.WriteLine();
    }
    Console.WriteLine();
}

void Average(int[,] array){
    Console.Write($"Среднее арифметическое каждого столбца: ");
    for(int j = 0; j < array.GetLength(1); j++){
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++){
            sum += array[i,j];
        }
        sum = sum / array.GetLength(0);
        sum = Math.Round(sum, 2);
        Console.Write($"{sum} ");
    }
    Console.WriteLine();
}

int[,] otvet = CreateRandomArray();
ShowRandomArray(otvet);
Average(otvet);
*/
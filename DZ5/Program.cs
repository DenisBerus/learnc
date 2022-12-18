/* 1
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2


int[] CreateRandomArray(int size){

    int[] array = new int[size];
    for(int i = 0; i < size; i++){
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}
void ShowRandomArray(int[] array){
            Console.Write("В массиве: ");
            for(int i = 0; i < array.Length; i++){
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
}
int Chetnie(int[] array){
    int count = 0;
    for(int i = 0; i < array.Length; i++){
        if(array[i] % 10 == 2 || array[i] % 10 == 4 || array[i] % 10 == 6 || array[i] % 10 == 8 || array[i] % 10 == 0){
        count += 1;
        }
    }
    return count;
}

int[] otvet = CreateRandomArray(4);
ShowRandomArray(otvet);
int otvem = Chetnie(otvet);
Console.WriteLine("Четных чисел в массиве "+ otvem);
*/


/* 2
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0

int[] CreateRandomArray(int size){

    int[] array = new int[size];
    for(int i = 0; i < size; i++){
        array[i] = new Random().Next(-100, 100);
    }
    return array;
}
void ShowRandomArray(int[] array){
            Console.Write("В массиве: ");
            for(int i = 0; i < array.Length; i++){
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
}
int Chetnie(int[] array){
    int count = 0;
    for(int i = 1; i < array.Length; i = i + 2){
        count += array[i];
        
    }
    return count;
}

int[] otvet = CreateRandomArray(4);
ShowRandomArray(otvet);
int otvem = Chetnie(otvet);
Console.WriteLine("Сумма элементов: "+ otvem);
*/


/* 3
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/
/*
int[] CreateRandomArray(int size){

    int[] array = new int[size];
    for(int i = 0; i < size; i++){
        array[i] = new Random().Next(0, 100);
    }
    return array;
}
void ShowRandomArray(int[] array){
            Console.Write("В массиве: ");
            for(int i = 0; i < array.Length; i++){
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
}
int Deltta(int[] arraym){
    int max = 0;
    int min = 100;
    int delta = 0;
    for(int y = 0; y < arraym.Length; y++){
        if(arraym[y] > max) max = arraym[y];
        if(arraym[y] < min) min = arraym[y];    
        }
        delta = max - min;
    return delta;
}

int[] otvet = CreateRandomArray(6);
ShowRandomArray(otvet);
int otvem = Deltta(otvet);
Console.WriteLine("Разница равна "+ otvem);
*/
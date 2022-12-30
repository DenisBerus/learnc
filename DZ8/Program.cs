/* - 1я задача 8 дз
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы 
каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
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

void ChangeArray(int[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            for(int x = j + 1; x < array.GetLength(1); x++){
                if(array[i,j] < array[i,x]){
                    int temp = array[i,j];
                    array[i,j] = array[i,x];
                    array[i,x] = temp;
                }
                }       
        Console.Write(array[i,j] + " "); 
        }
    Console.WriteLine(); 
    }
}
int[,] otvet = CreateRandomArray();
ShowRandomArray(otvet);
ChangeArray(otvet);
*/

/* - 2я задача 8 дз
Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт 
номер строки с наименьшей суммой элементов: 1 строка
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

int ChangeArray(int[,] array){
    int min = 0;
    int minSum = 100;
    for(int i = 0; i < array.GetLength(0); i++){
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++){
            sum += array[i,j];
            }
            Console.WriteLine($"Сумма строки {i} равна {sum}");
            if(minSum > sum) min = i;
            if(minSum > sum) minSum = sum;
    }
    Console.WriteLine($"Минимальная сумма {minSum}");
    return min;
}

int[,] otvet = CreateRandomArray();
ShowRandomArray(otvet);
int ottvet = ChangeArray(otvet);
Console.WriteLine($"Индекс минимальной строчки {ottvet}");
int stringo = ottvet + 1;
Console.WriteLine($"Строка с минимальным значением {stringo}");
*/

/* - 3я задача 8 дз
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

/*
int[,] CreateRandomArray(){
    int[,] array = new int[2,2];
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

int[,] newArrayDo(int[,] array1, int[,] array2){
      
      if (array1.GetLength(0) != array2.GetLength(1))
        {
            Console.WriteLine("Массивы нельзя перемножить. Результат некорректен.");
        }

    int[,] arrayF = new int[2,2];
    for(int i = 0; i < arrayF.GetLength(0); i++){
        for (int j = 0; j < arrayF.GetLength(1); j++){
            //arrayF[i,j] = array1[i,j] * array2[i,j] + array1[i,j] * array2[j,i];  
                arrayF[i, j] = 0;
                for (int k = 0; k < arrayF.GetLength(1); k++)
                {
                    arrayF[i, j] += array1[i, k] * array2[k, j];
                }
        }
}
return arrayF;
}

int[,] otvet = CreateRandomArray();
ShowRandomArray(otvet);
int[,] otvet1 = CreateRandomArray();
ShowRandomArray(otvet1);
int[,] newar = newArrayDo(otvet, otvet1);
ShowRandomArray(newar);
*/

/* - 4я задача 8 дз
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

/*
int[,,] CreateRandomArray(){
    int[,,] array = new int[2,2,2];
        for(int i = 0; i < array.GetLength(0); i++){
            for (int j = 0; j < array.GetLength(1); j++){
                for (int k = 0; k < array.GetLength(2); k++){
                    array[i,j,k] = new Random().Next(10,100);
                    if(array[i,j,k] == array[i,j,k]) array[i,j,k] = new Random().Next(10,100);
                }
            }
        }     
    return array;   
}
void ShowRandomArray(int[,,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            for (int k = 0; k < array.GetLength(2); k++){
                Console.Write($"{array[i,j,k]} {(i,j,k)} ");
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,,] otvet = CreateRandomArray();
ShowRandomArray(otvet);
*/


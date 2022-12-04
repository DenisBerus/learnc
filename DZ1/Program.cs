//ЗАДАЧА 1
/*
Console.Write("Input an integer numberA: ");
int numA = Convert.ToInt32(Console.ReadLine());

Console.Write("Input an integer numberB: ");
int numB = Convert.ToInt32(Console.ReadLine());

if (numA > numB)
{
    Console.WriteLine("max = " + (numA) + " ");
}
else 
{
    Console.WriteLine("max = " + (numB) + " ");
}
*/



// ЗАДАЧА 2
/*
Console.Write("Input an integer numberA: ");
int numA = Convert.ToInt32(Console.ReadLine());

Console.Write("Input an integer numberB: ");
int numB = Convert.ToInt32(Console.ReadLine());

Console.Write("Input an integer numberС: ");
int numC = Convert.ToInt32(Console.ReadLine());

int max = numA;
if (numB > max) max = numB;
if (numC > max) max = numC;

Console.WriteLine(max);
*/



// ЗАДАЧА 3
/*
Console.Write("Input an integer numberA: ");
int numA = Convert.ToInt32(Console.ReadLine());

int result = numA % 2;

if (result > 0)
{
    Console.WriteLine("нечетное");
}

else 
{
    Console.WriteLine("четное");
}
*/



// ЗАДАЧА 4
/*
Console.Write("Input an integer N: ");
int N = Convert.ToInt32(Console.ReadLine());

int current = 2;
int numN = N % 2;
if (numN == 0)
{
    while (current <= N)
    {
        Console.WriteLine(current);
        current = current + 2;
    }
}
else
{
    while (current < N)
    {
        Console.WriteLine(current);
        current = current + 2;
    }
}
*/

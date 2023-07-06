// Задача 47: Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();
int m = Prompt("Введите кол-во строк");
int n = Prompt("Введите кол-во столбцов");

double[,] array = GetArray(m,n);
PrintArray(array);
//-----------------------------------------------------------------------------
int Prompt(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"|{array[i, j]}| ");
        }
        Console.WriteLine();
    }
}

double[,] GetArray(int m, int n)
{
    double[,] array = new double[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().NextDouble()*10;
            array[i, j] = Math.Round(array[i,j],1);
        }
    }
    return array;
}
// Задача 52: Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом
// столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого
// столбца: |4,6| |5,6| |3,6| |3,0|

Console.Clear();
int m = Prompt("Введите кол-во строк");
int n = Prompt("Введите кол-во столбцов");

//задаём массив случайных чисел
int[,] array1 = GetArray(m, n);
//выводим его на экран
PrintArray(array1);
Console.WriteLine();
//транспонируем заданный массив случайных чисел
int[,] array2 = TransposedArray(n,m);
//находим среднее арифметическое
int[,] array3 = new int[n, m];
for (int i = 0; i < array3.GetLength(0); i++)
{
    double sum = 0;
    int count = 0;
    for (int j = 0; j < array3.GetLength(1); j++)
    {
        sum = array2[i, j] + sum;
        count++;
    }
    Console.Write($"|{Math.Round((sum / count), 2)}| ");
}

//-----------------------------------------------------------------------------
int Prompt(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}
// метод вывода массива на экран
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
// метод заполнения массива случайными значениями
int[,] GetArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 9);
        }
    }
    return array;
}
// метод транспонирования массива
int[,] TransposedArray(int m, int n)
{
    int[,] array2 = new int[m, n];
    for (int i = 0; i < array2.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            array2[i, j] = array1[j, i];
        }
    }
    return array2;
}
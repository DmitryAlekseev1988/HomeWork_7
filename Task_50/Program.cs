// Задача 50: Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Clear();
int m = Prompt("Введите кол-во строк");
int n = Prompt("Введите кол-во столбцов");
int find = Prompt("Введите искомый элемент");
int[,] array1 = GetArray(m, n);
PrintArray(array1);
Console.WriteLine("");
// Проверка, существует ли элемент в массиве
bool finded = false;

int[,] array2 = new int[m, n];
for (int i = 0; i < array2.GetLength(0); i++)
{
    for (int j = 0; j < array2.GetLength(1); j++)
    {
        if (array1[i, j] == find)
        {
            finded = true;
            break;
        }

    }
}

if (finded == true)
    Console.Write($"{find} -> Такой элемент есть в массиве!");
else
    Console.Write($"{find} -> Такого элемента нет");

//-----------------------------------------------------------------------------
int Prompt(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

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

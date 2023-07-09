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
int str = Prompt("Введите позицию элемента по стороке ");
int column = Prompt("Введите позицию элемента по столбцу ");
int[,] array1 = GetArray(m, n);
PrintArray(array1);
Console.WriteLine("");

// вывод искомого элемента по индексу

bool index = false;
int element = 0;

int[,] array2 = new int[m, n];
for (int i = 0; i < array2.GetLength(0); i++)
{
    for (int j = 0; j < array2.GetLength(1); j++)
    {
        if (i == str & j == column)
        {
            index = true;
            element = array1[i, j];
            break;
        }
    }
}

if (index == true)
    Console.Write($"На позиции [{str},{column}] содержиться элемент [{element}]");
else
    Console.Write($"такой позиции не существует!");

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
            array[i, j] = new Random().Next(-15, 15);

        }
    }
    return array;
}

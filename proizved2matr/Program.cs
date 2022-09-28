// Произведением двух матриц А и В называется матрица С, элемент которой, находящийся на пересечении i -й строки и j -го столбца, равен
// сумме произведений элементов i -й строки матрицы А на соответствующие (по порядку) элементы j -го столбца матрицы В. 
// Из этого определения следует формула элемента матрицы C: Произведение матрицы А на матрицу В обозначается АВ.

// Задача 2: Задайте две квадратные матрицы одного размера. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int m = 2;
int n = 2;
int[,] array = new int[m, n];
int[,] array1 = new int[m, n];
int[,] array2 = new int[m, n];
FillArray(array);
PrintArray(array);
System.Console.WriteLine();
FillArray(array1);
PrintArray(array1);
Multiply(array, array1, array2);
System.Console.WriteLine("Произведение двух матриц:");
PrintArray(array2);

void FillArray(int[,] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

void Multiply(int[,] array, int[,] array1, int[,] array2)
{
    for (int i = 0; i < array.GetLength(0) && i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) && j < array1.GetLength(1); j++)
        {
           for (int k = 0; k < array.GetLength(0); k++)
                array2[i, j] += array[i, k] * array1[k, j];
        }
    }
}
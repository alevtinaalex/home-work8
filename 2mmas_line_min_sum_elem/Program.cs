// Задайте двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Номер строки с наименьшей суммой элементов: 1 строка
// (допускается указывать индекс строки в массиве, в данном примере - 0)


int m = 4;
int n = 4;
int[,] array = new int[m, n];
int[] array1 = new int[m];

FillAndPrintArray(array);
System.Console.WriteLine("Сумма элементов в строке");
SrArifm(array, array1);
System.Console.WriteLine("[{0}]", string.Join(" , ", array1));
Minimum(array1, out int min);
System.Console.WriteLine($"Минимальная сумма элементов в строке = {min}");

void FillAndPrintArray(int[,] array)
{
    Random rnd  = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0, 10);
            System.Console.Write(array[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

void SrArifm(int[,] array, int[] array1)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        array1[i] = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array1[i] = array1[i] + array[i, j];
        }
    }
}

void Minimum(int[] array1, out int min)
{
    min = array1[0];
    int minIndexRow = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i] < min)
        {
            min = array1[i];
            minIndexRow = i;
        }
    }
    System.Console.WriteLine($"Индекс строки с наименьшей суммой элементов = {minIndexRow}");
}
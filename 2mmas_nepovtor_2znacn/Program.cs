// Сформируйте двухмерный массив из неповторяющихся случайных двузначных чисел (размер массива не более 50 элементов). Напишите программу,
// которая будет построчно выводить массив.
// Вариант создания функции:
// Проверить число на присутствие в массиве (bool Contains(int[,] arr, int value){...} )
// Пример:
// Массив размером 3 x 3
// 10 11 55
// 33 41 23
// 17 28 34

int m = 3;
int n = 3;
int[,] array = new int[m, n];
FillAndPrintArray(array);

void FillAndPrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Random rnd  = new Random();
            int tmp = rnd.Next(10,99);
            array[i, j] = rnd.Next(10, 99);
            while (true)
            {
                if(!CheckNumber(array,tmp))
                {
                        break;
                }
                tmp = rnd.Next(10,99);
            }
            array[i, j] = tmp;
            System.Console.Write(array[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

bool CheckNumber(int[,] array, int value)
{
    for (int i = 0; i < array.GetLength(0)-1; i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i,j] == value)
            return true;
        }
    }
    return false;
}
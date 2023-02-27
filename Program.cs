// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


Console.Write("Input count of rows: ");
int user_rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input count of columns: ");
int user_columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input minimum value: ");
int user_min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input maximum value: ");
int user_max = Convert.ToInt32(Console.ReadLine());


int [,] Created2dArray (int user_rows)
{     
    int [,] createdArray = new int[user_rows, user_columns];
    for (int i = 0; i < user_rows; i++)
    {
        for (int j = 0; j < user_columns; j++)
        {
            createdArray[i,j] = new Random().Next(user_min, user_max + 1);

        }
    }
    return createdArray;
}

void Show2dArray (int [,] array) 
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write (array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] array = Created2dArray(user_rows, user_columns);

Created2dArray();
Console.WriteLine();
Show2dArray(array);

int [,] ChangeArray (int [] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            for (int z = 0; z < array.GetLength(1) - 1; z++)
            {
                if (array[i, z] < array[i, z + 1]) 
                {
                    int temp = 0;
                    temp = array[i, z];
                    array[i, z] = array[i, z + 1];
                    array[i, z + 1] = temp;
                }
            }
        }
    }
    return array;
}    
Console.WriteLine();

Show2dArray(Created2dArray);



// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

/*
int MinSumOfRow(int[,] int2DArray)
{
    int[] sumRow = new int[int2DArray.GetLength(0)];

    for (int i = 0; i < int2DArray.GetLength(0); i++)
    {
        for (int j = 0; j < int2DArray.GetLength(1); j++)
        {
            sumRow[i] += int2DArray[i, j];
        }
        Console.WriteLine($"Sum of the numbers in {i + 1}-row = {sumRow[i]}");
    }
    
    int sum = sumRow[0];
    int minIndex = 0;

    for (int i = 0; i < sumRow.Length; i++)
    {
        if (sumRow[i] < sum)
        {
            sum = sumRow[i];
            minIndex = i;
        }
    }
    
    return minIndex + 1;
}
int[,] myArray = Created2dArray();
Show2dArray(myArray);
int rowIndex = MinSumOfRow(myArray);
Console.WriteLine($"The smallest sum of the numbers in the row - {rowIndex}");
*/
// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается 
// элемент входных данных.
// 1, 9, 9, 0,
// 2, 8, 0, 9
// 0 встречается 2 раза
// 1 встречается 1 раз
// 2 встречается 1 раз
// 8 встречается 1 раз
// 9 встречается 3 раза


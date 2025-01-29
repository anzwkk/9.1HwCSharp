﻿//Написати програму, що знаходить другий найбільший елемент масиву.
//int[] array = { 10, 20, 5, 8, 30, 25 };
//int max1 = array[0];
//int max2 = array[0];

//for (int i = 1; i < array.Length; i++)
//{
//    if (array[i] > max1)
//    {
//        max2 = max1;
//        max1 = array[i];
//    }
//    else if (array[i] > max2 && array[i] != max1)
//    {
//        max2 = array[i];
//    }
//}
//Console.WriteLine("Другий найбільший елемент: " + max2);

//Написати програму, що буде сортувати за зростанням елементи двовимірного масиву.
int[,] matrix = {
            { 5, 3, 9 },
            { 1, 7, 6 },
            { 8, 4, 2 }
        };
int rows = matrix.GetLength(0); 
int cols = matrix.GetLength(1);

int[] temp = new int[rows * cols];
int index = 0;

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        temp[index++] = matrix[i, j];
    }
}
Array.Sort(temp);

index = 0;
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        matrix[i, j] = temp[index++];
    }
}

Console.WriteLine("Відсортований двовимірний масив: ");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}
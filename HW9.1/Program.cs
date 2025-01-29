//Написати програму, що знаходить другий найбільший елемент масиву.
int[] array = { 10, 20, 5, 8, 30, 25 };
int max1 = array[0];
int max2 = array[0];

for (int i = 1; i < array.Length; i++)
{
    if (array[i] > max1)
    {
        max2 = max1;
        max1 = array[i];
    }
    else if (array[i] > max2 && array[i] != max1)
    {
        max2 = array[i];
    }
}
Console.WriteLine("Другий найбільший елемент: " + max2);

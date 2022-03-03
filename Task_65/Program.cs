using System;

void FillArray(int[,] array)
{
    int num = 0, M = array.GetLength(0), N = array.GetLength(1), i = 0, j = 0, number = 1;

    while (number <= M * N)
    {
        array[i, j] = number;

        if (i == num && j < N - num - 1) j++;
        else if (j == N - num - 1 && i < M - num - 1) i++;
        else if (i == M - num - 1 && j > num) j--; 
        else i--;

        if (i == num + 1 && j == num && num != N - num - 1)
        {
            num++;
        }
        number++;
    }
}

void PrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == array.GetLength(1) - 1) Console.Write($"{array[i, j]} ");
            else Console.Write($"{array[i, j]} ");
            
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

//Если выставлять больше строк и столбцов, начинает съезжать, не понимаю как исправить. 
//Пытался добавлять пустые строки числам меньше нуля, но тогда ломался код.
int[,] array = new int[3, 3];
FillArray(array);
PrintArray(array);
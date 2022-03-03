using System;

int[,,] array = new int[4, 4, 4];

void FirstArray(int[,,] array)
{
    int number = 10;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int l = 0; l < array.GetLength(2); l++)
            {
                array[i, j, l] = number;
                number++;
            }
        }
    }
}

void WriteArray(int[,,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int l = 0; l < array.GetLength(2); l++)
            {
                Console.WriteLine($"Индексам [{i}-{j}-{l}] присвоено значение {array[i, j, l]} ");

            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

FirstArray(array);
WriteArray(array);
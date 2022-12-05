int[,] table = new int[4, 5];
FillArrayRandom(table);
PrintArray(table);
SortToLower(table);
Console.WriteLine();
PrintArray(table);

void FillArrayRandom(int[,] array)
{
    for (int a = 0; a < array.GetLength(0); a++)
    {
        for (int b = 0; b < array.GetLength(1); b++)
        {
            array[a, b] = new Random().Next(1, 10);
        }
    }
}

void SortToLower(int[,] array)
{
    for (int a = 0; a < array.GetLength(0); a++)
    {
        for (int b = 0; b < array.GetLength(1); b++)
        {
            for (int c = 0; c < array.GetLength(1) - 1; c++)
            {
                if (array[a, c] < array[a, c + 1])
                {
                    int temp = array[a, c + 1];
                    array[a, c + 1] = array[a, c];
                    array[a, c] = temp;
                }
            }
        }
    }
}

void PrintArray(int[,] array)
{
    for (int a = 0; a < array.GetLength(0); a++)
    {
        for (int b = 0; b < array.GetLength(1); b++)
        {
            Console.Write($"{array[a, b]} ");
        }
        Console.WriteLine();
    }
}

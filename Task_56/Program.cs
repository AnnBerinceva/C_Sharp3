int[,] table = new int[4, 4];
FillArrayRandom(table);
PrintArray(table);
Console.WriteLine();
NumberRowMinSumElements(table);

void NumberRowMinSumElements(int[,] array)
{
    int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;
    for (int a = 0; a < table.GetLength(1); a++)
    {
        minRow += table[0, a];
    }
    for (int a = 0; a < table.GetLength(0); a++)
    {
        for (int b = 0; b < table.GetLength(1); b++) sumRow += table[a, b];
        if (sumRow < minRow)
        {
            minRow = sumRow;
            minSumRow = a;
        }
        sumRow = 0;
    }
    Console.Write($"{minSumRow + 1} строка");
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
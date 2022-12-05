Console.WriteLine("");
int a = InputNumbers("Количество строк 1 матрицы ");
int b = InputNumbers("Количество столбцов 1 матрицы/строк 2 матрицы ");
int c = InputNumbers("Количество столбцов 2 матрицы ");
int range = InputNumbers("Диапазон случайных значений: от 1 до ");

int[,] firstMartrix = new int[a, b];
CreateArray(firstMartrix);
Console.WriteLine($"1 матрица");
WriteArray(firstMartrix);

int[,] secomdMartrix = new int[b, c];
CreateArray(secomdMartrix);
Console.WriteLine($"2 матрица:");
WriteArray(secomdMartrix);

int[,] resultMatrix = new int[a,c];

MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
Console.WriteLine($"Произведение 2х матриц ");
WriteArray(resultMatrix);

void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
  for (int x = 0; x < resultMatrix.GetLength(0); x++)
  {
    for (int y = 0; y < resultMatrix.GetLength(1); y++)
    {
      int sum = 0;
      for (int z = 0; z < firstMartrix.GetLength(1); z++)
      {
        sum += firstMartrix[x,z] * secomdMartrix[z,y];
      }
      resultMatrix[x,y] = sum;
    }
  }
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void CreateArray(int[,] array)
{
  for (int x = 0; x < array.GetLength(0); x++)
  {
    for (int y = 0; y < array.GetLength(1); y++)
    {
      array[x, y] = new Random().Next(range);
    }
  }
}

void WriteArray (int[,] array)
{
  for (int x = 0; x < array.GetLength(0); x++)
  {
    for (int y = 0; y < array.GetLength(1); y++)
    {
      Console.Write(array[x,y] + " ");
    }
    Console.WriteLine();
  }
}
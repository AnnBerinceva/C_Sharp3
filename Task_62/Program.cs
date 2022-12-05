int a = 4;
int[,] sqareMatrix = new int[a, a];

int temp = 1;
int b = 0;
int c = 0;

while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
{
  sqareMatrix[b, c] = temp;
  temp++;
  if (b <= c + 1 && b + c < sqareMatrix.GetLength(1) - 1)
    c++;
  else if (b < c && b + c >= sqareMatrix.GetLength(0) - 1)
    b++;
  else if (b >= c && b + c > sqareMatrix.GetLength(1) - 1)
    c--;
  else
    b--;
}

WriteArray(sqareMatrix);

void WriteArray (int[,] array)
{
  for (int b = 0; b < array.GetLength(0); b++)
  {
    for (int c = 0; c < array.GetLength(1); c++)
    {
      if (array[b,c] / 10 <= 0)
      Console.Write($" {array[b,c]} ");

      else Console.Write($"{array[b,c]} ");
    }
    Console.WriteLine();
  }
}
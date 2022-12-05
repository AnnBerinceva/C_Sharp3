Console.WriteLine($"размер массива a x b x c: ");
int a = InputNumbers("Значение a ");
int b = InputNumbers("Значение b ");
int c = InputNumbers("Значение c ");
Console.WriteLine($"");

int[,,] array3D = new int[a, b, c];
CreateArray(array3D);
WriteArray(array3D);

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void WriteArray (int[,,] array3D)
{
  for (int m = 0; m < array3D.GetLength(0); m++)
  {
    for (int n = 0; n < array3D.GetLength(1); n++)
    {
      Console.Write($"X({m}) Y({n}) ");
      for (int k = 0; k < array3D.GetLength(2); k++)
      {
        Console.Write( $"Z({k})={array3D[m,n,k]}; ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}

void CreateArray(int[,,] array3D)
{
  int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
  int  number;
  for (int m = 0; m < temp.GetLength(0); m++)
  {
    temp[m] = new Random().Next(10, 100);
    number = temp[m];
    if (m >= 1)
    {
      for (int n = 0; n < m; n++)
      {
        while (temp[m] == temp[n])
        {
          temp[n] = new Random().Next(10, 100);
          n = 0;
          number = temp[m];
        }
          number = temp[m];
      }
    }
  }
  int count = 0; 
  for (int a = 0; a < array3D.GetLength(0); a++)
  {
    for (int b = 0; b < array3D.GetLength(1); b++)
    {
      for (int c = 0; c < array3D.GetLength(2); c++)
      {
        array3D[a, b, c] = temp[count];
        count++;
      }
    }
  }
}
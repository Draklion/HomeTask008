void CW(string msg)
{
  Console.WriteLine(msg);
}
void CWR(string msg)
{
  Console.Write(msg);
}
string CR()
{
  return Console.ReadLine();
}

int[,] Random(int rows, int columns)
{
  int[,] array = new int[rows, columns];
  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < columns; j++)
    {
      array[i, j] = new Random().Next(0, 100);
    }

  }
  return array;
}

void Print(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      CWR(array[i, j].ToString() + "  ");
    }
    CW("");
  }
}

try
{
  CW("Задание 8. Программа, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.");

  int rows = new Random().Next(1, 6);
  int columns = new Random().Next(1, 6);

  int[,] Matrix = new int[rows, columns];
  int[,] resultMatrix = new int[rows - 1, columns - 1];
  int index1 = 0, index2 = 0;
  if (rows == 1 || columns == 1) { }
  Matrix = Random(rows, columns);
  Print(Matrix);
  CW("");
  int min = Matrix[0, 0];
  for (int i = 0; i < Matrix.GetLength(0) * Matrix.GetLength(1); i++)
  {
    for (int j = 0; j < Matrix.GetLength(0); j++)
    {
      for (int k = 0; k < Matrix.GetLength(1); k++)
      {
        if (min < Matrix[j, k]) continue;
        else min = Matrix[j, k];
        index1 = j;
        index2 = k;
      }
    }
  }

  for (int i = 0, j = 0; i < Matrix.GetLength(0); i++, j++)
  {
    if (index1 != i)
    {
      for (int n = 0, m = 0; n < Matrix.GetLength(1); n++, m++)
        if (index2 != n)
          resultMatrix[j, m] = Matrix[i, n];
        else m--;
    }
    else j--;
  }
  Print(resultMatrix);
}
catch (InvalidCastException e) { }

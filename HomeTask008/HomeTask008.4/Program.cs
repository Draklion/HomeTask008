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
      array[i, j] = new Random().Next(0, 10);
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
  CW("Задание 4. Программа, которая будет находить произведение двух матриц.");

  int rows = new Random().Next(1, 6);
  int columns = new Random().Next(1, 6);
  int rows2 = new Random().Next(1, 6);
  int columns2 = new Random().Next(1, 6);
  int[,] firstMatrix = new int[rows, columns];
  int[,] secondMatrix = new int[rows2, columns2];
  int[,] resultMatrix = new int[rows, columns2];

  if (columns == rows2)
  {
    CW("Первая матрица:");
    firstMatrix = Random(rows, columns);
    Print(firstMatrix);

    CW("Вторая матрица:");
    secondMatrix = Random(rows2, columns2);
    Print(secondMatrix);

    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
      for (int j = 0; j < secondMatrix.GetLength(1); j++)
      {
        for (int k = 0; k < secondMatrix.GetLength(0); k++)
        {
          resultMatrix[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
        }
      }
    }

    CW("Результат вычисления:");
    Print(resultMatrix);

  }
  else { CW("Умножение матриц не возможно, поскольку количество столбцов первой матрицы не равно колчествустрок во второй матрице."); }
}

catch (InvalidCastException e) { }

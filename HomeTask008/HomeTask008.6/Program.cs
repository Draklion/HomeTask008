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
  CW("Задание 6. Программа, которая находит строку с наименьшей суммой элементов.");

  int rows = new Random().Next(1, 6);
  int columns = new Random().Next(1, 6);

  int[,] firstMatrix = new int[rows, columns];
  int[] resultMatrix = new int[rows];

  firstMatrix = Random(rows, columns);
  Print(firstMatrix);
  CW("");
  if (rows == 1) CW("В массиве одна строка.");

  else
  {
    CW("Суммы строк:");
    resultMatrix[0] = 0;
    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
      for (int j = 0; j < firstMatrix.GetLength(1); j++) resultMatrix[i] = resultMatrix[i] + firstMatrix[i, j];
      CWR(resultMatrix[i].ToString() + "  ");
    }
    CW("");

    int min = resultMatrix[0];
    for (int i = 1; i < resultMatrix.Length; i++)
    {
      if (min < resultMatrix[i]) continue;
      else min = resultMatrix[i];
    }
    for (int i = 0; i < resultMatrix.Length; i++) if (min == resultMatrix[i]) CW($"Строка с наименьшей суммой элементов: {i + 1}");
  }
}

catch (InvalidCastException e) { }

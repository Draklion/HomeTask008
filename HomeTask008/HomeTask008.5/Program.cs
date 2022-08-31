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

try
{
  CW("Задание 5. Программа, которая упорядочит по убыванию элементы каждой строки двумерного массива.");

  int rows = new Random().Next(1, 6);
  int columns = new Random().Next(1, 6);
  int[,] array = new int[rows, columns];
  CW("Исходный массив:");

  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < columns; j++)
    {
      array[i, j] = new Random().Next(0, 10);
      CWR(array[i, j].ToString() + "  ");
    }
    CW("");
  }

  for (int i = 0; i < array.GetLength(0) * array.GetLength(1); i++)
  {
    for (int j = 0; j < array.GetLength(0); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[j, k] > array[j, k + 1])
        {
          int count = array[j, k];
          array[j, k] = array[j, k + 1];
          array[j, k + 1] = count;
        }
      }
    }
  }
  CW("");
  CW("Отсортированный массив:");
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      CWR(array[i, j].ToString() + "  ");
    }
    CW("");
  }
}
catch (InvalidCastException e) { }

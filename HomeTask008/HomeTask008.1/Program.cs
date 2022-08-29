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
  CW("Задание 1. Программа, которая поменяет местами первую и последнюю строку массива.");

  int rows = new Random().Next(1, 6);
  int columns = new Random().Next(1, 6);
  int[,] array = new int[rows, columns];
  int[] array2 = new int[columns];

  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < columns; j++)
    {
      array[i, j] = new Random().Next(-10, 10);
      CWR(array[i, j].ToString() + "  ");
    }
    CW("");
  }
  CW("Измененный массив:");
  for (int i = 0; i < columns; i++)
  {
    array2[i] = array[0, i];
    array[0, i] = array[rows - 1, i];
    array[rows - 1, i] = array2[i];
  }

  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < columns; j++)
    {
      CWR(array[i, j].ToString() + "  ");
    }
    CW("");
  }

}
catch (InvalidCastException e) { }

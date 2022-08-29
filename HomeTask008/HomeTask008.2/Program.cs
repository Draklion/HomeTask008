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
  CW("Задание 2. Программа, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.");

  int rows = new Random().Next(2, 6);
  int columns = new Random().Next(2, 6);
  int[,] array = new int[rows, columns];
  int[,] array2 = new int[columns, rows];

  if (columns == 0 || rows == 0) { CW("Значение строк или столбцов равно 0 и массив не может быть сформирован."); }
  else
  {
    for (int i = 0; i < rows; i++)
    {
      for (int j = 0; j < columns; j++)
      {
        array[i, j] = new Random().Next(0, 10);
        CWR(array[i, j].ToString() + "  ");
      }
      CW("");
    }
    CW("Измененный массив:");
    for (int i = 0; i < rows; i++)
    {
      for (int j = 0; j < columns; j++)
      {
        array2[j, i] = array[i, j];
      }
    }

    for (int i = 0; i < columns; i++)
    {
      for (int j = 0; j < rows; j++)
      {
        CWR(array2[i, j].ToString() + "  ");
      }
      CW("");
    }
  }
}
catch (InvalidCastException e) { }

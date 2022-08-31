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
  CW("Задание 3. Программа, которая составляет частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.");

  int rows = new Random().Next(1, 6);
  int columns = new Random().Next(1, 6);
  int[,] array = new int[rows, columns];
  int[] array2 = new int[rows * columns];
  int index = 0;
  int count = 0;


  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < columns; j++)
    {
      array[i, j] = new Random().Next(0, 10);
      CWR(array[i, j].ToString() + "  ");
      array2[index] = array[i, j];
      index++;
    }
    CW("");
  }

  for (int i = 0; i < array2.Length; i++)
  {
    for (int j = 0; j < array2.Length - 1; j++)
    {
      if (array2[j] > array2[j + 1])
      {
        int count2 = array2[j + 1];
        array2[j + 1] = array2[j];
        array2[j] = count2;
      }
    }
  }
  CW("");

  int prev = array2[0];

  for (int i = 0; i < array2.Length; i++)
  {
    if (prev == array2[i]) count++;
    else
    {
      CW($"{prev} встречается {count} раз");
      prev = array2[i];
      count = 1;
    }
  }
  CW($"{prev} встречается {count} раз");
}
catch (InvalidCastException e) { }

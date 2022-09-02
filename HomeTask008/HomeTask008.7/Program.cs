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
  CW("Задание 7. Программа, которая будет построчно выводить массив, добавляя индексы каждого элемента.");

  int[,,] Matrix = new int[2, 2, 2] {
    { {10,74},{47,425} },
    { {5,71}, {12,75} }
    };

  for (int i = 0; i < Matrix.GetLength(0); i++)
  {
    for (int j = 0; j < Matrix.GetLength(1); j++)
    {
      for (int k = 0; k < Matrix.GetLength(2); k++) CWR($"{Matrix[i, j, k]}({i}{j}{k}) ");
    }
    CW("");
  }
}
catch (InvalidCastException e) { }

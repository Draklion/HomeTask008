string number = Console.ReadLine();
int sum = 0;
void Sum(string number, int i = 0)
{
  if (number.Length == i)
  {
    sum = sum + Int32.Parse(number[i].ToString());
    Sum(number, i++);
  }
  Console.WriteLine(sum);
}

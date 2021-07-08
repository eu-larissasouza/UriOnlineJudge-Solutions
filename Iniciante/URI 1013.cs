using System;

class URI
{

  public static void Main(string[] args)
  {

    int MaiorAB = 0;

    string line1 = Console.ReadLine();

    string[] values = line1.Split(' ');
    int a = Int32.Parse(values[0]);
    int b = Int32.Parse(values[1]);
    int c = Int32.Parse(values[2]);

    MaiorAB = (a + b + Math.Abs(a - b)) / 2;

    if (MaiorAB > c)
    {
      Console.WriteLine("{0} eh o maior", MaiorAB);
    }
    else
    {
      Console.WriteLine("{0} eh o maior", c);
    }
  }
}
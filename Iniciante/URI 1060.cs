using System;

class URI
{

  public static void Main(string[] args)
  {

    double num;
    int val = 0, i;

    for (i = 1; i <= 6; i++)
    {
      num = Double.Parse(Console.ReadLine());
      if (num >= 0)
      {
        val += val + 1;
      }
    }

    Console.WriteLine(val + " valores positivos");

  }
}
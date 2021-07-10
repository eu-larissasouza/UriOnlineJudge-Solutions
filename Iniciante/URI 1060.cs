using System;

class URI
{

  public static void Main(string[] args)
  {

    double[] num= new double[6];
    int val = 0; int i;

    for (i = 0; i <= 5; i++)
    {
      num[i] = Double.Parse(Console.ReadLine());
      if (num[i] > 0)
      {
        val++;
      }
    }

    Console.WriteLine(val + " valores positivos");

  }
}
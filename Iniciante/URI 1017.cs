using System;

class URI
{

  public static void Main(string[] args)
  {

    int tg, vm, dp;
    double ql;

    string line1 = Console.ReadLine();

    string[] values1 = line1.Split(' ');
    tg = Int32.Parse(values1[0]);
    vm = Int32.Parse(values1[1]);

    dp = tg * vm;

    ql = dp / 12.0;

    Console.WriteLine("{0:F3}", ql);

  }
}
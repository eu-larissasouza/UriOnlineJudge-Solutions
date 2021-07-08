using System;

class URI
{
  public static void Main(string[] args)
  {
    int X, N, n100, n50, n20, n10, n5, n2, n1;

    N = Int32.Parse(Console.ReadLine());
    X = N;

    n100 = N / 100;
    N -= (n100 * 100);

    n50 = N / 50;
    N -= (n50 * 50);

    n20 = N / 20;
    N -= (n20 * 20);

    n10 = N / 10;
    N -= (n10 * 10);

    n5 = N / 5;
    N -= (n5 * 5);

    n2 = N / 2;
    N -= (n2 * 2);

    n1 = N;

    Console.WriteLine("{0}", X);
    Console.WriteLine("{0} nota(s) de R$ 100,00", n100);
    Console.WriteLine("{0} nota(s) de R$ 50,00", n50);
    Console.WriteLine("{0} nota(s) de R$ 20,00", n20);
    Console.WriteLine("{0} nota(s) de R$ 10,00", n10);
    Console.WriteLine("{0} nota(s) de R$ 5,00", n5);
    Console.WriteLine("{0} nota(s) de R$ 2,00", n2);
    Console.WriteLine("{0} nota(s) de R$ 1,00", n1);

  }
}
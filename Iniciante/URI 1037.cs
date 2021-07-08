using System;

class URI
{

  public static void Main(string[] args)
  {

    double X;

    X = Double.Parse(Console.ReadLine());

    if (X >= 0 && X <= 25.0000)
      Console.WriteLine("Intervalo [0,25]");

    else if (X > 25.0000 && X <= 50.0000)
      Console.WriteLine("Intervalo (25,50]");

    else if (X > 50.0000 && X <= 75.0000)
      Console.WriteLine("Intervalo (50,75]");

    else if (X > 75.0000 && X <= 100.0000)
      Console.WriteLine("Intervalo (75,100]");

    else
      Console.WriteLine("Fora de intervalo");

  }
}
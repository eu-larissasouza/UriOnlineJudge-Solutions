using System;

class URI
{

  public static void Main(string[] args)
  {

    int A, B, C, D;

    string line1 = Console.ReadLine();

    string[] values1 = line1.Split(' ');
    A = Int32.Parse(values1[0]);
    B = Int32.Parse(values1[1]);
    C = Int32.Parse(values1[2]);
    D = Int32.Parse(values1[3]);

    if ((B > C) && (D > A) && (C + D > A + B) && (C > 0) && (D > 0) && (A % 2 == 0))
      Console.WriteLine("Valores aceitos");

    else
      Console.WriteLine("Valores nao aceitos");

  }
}
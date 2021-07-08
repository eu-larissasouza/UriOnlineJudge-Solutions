using System;

class URI {

  public static void Main(string[] args) {

    double A, B, C;
    double aux;

    string line1 = Console.ReadLine();

    string[] values = line1.Split(' ');
    A = Convert.ToDouble(values[0]);
    B = Convert.ToDouble(values[1]);
    C = Convert.ToDouble(values[2]);

    if (A < B) {
      aux = A;
      A = B;
      B = aux;
    }
    if (A < C) {
      aux = A;
      A = C;
      C = aux;
    }
    if (B < C) {
      aux = B;
      B = C;
      C = aux;
    }

    if (A >= B + C)
      Console.WriteLine("NAO FORMA TRIANGULO");
    else {
      if (Math.Pow(A, 2) == (Math.Pow(B, 2) + Math.Pow(C, 2)))
        Console.WriteLine("TRIANGULO RETANGULO");

      if (Math.Pow(A, 2) > Math.Pow(B, 2) + Math.Pow(C, 2))
        Console.WriteLine("TRIANGULO OBTUSANGULO");

      if (Math.Pow(A, 2) < Math.Pow(B, 2) + Math.Pow(C, 2))
        Console.WriteLine("TRIANGULO ACUTANGULO");

      if (A == B && A == C && B == C)
        Console.WriteLine("TRIANGULO EQUILATERO");

      else {
        if (A == B || A == C || B == C)
          Console.WriteLine("TRIANGULO ISOSCELES");
      }
    }

  }
}
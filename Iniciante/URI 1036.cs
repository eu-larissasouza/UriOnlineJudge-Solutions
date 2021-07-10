using System;

class URI {

  public static void Main(string[] args) {

    double A, B, C, delta, R1, R2;

    string line = Console.ReadLine();

    string[] values = line.Split(' ');
    A = Convert.ToDouble(values[0]);
    B = Convert.ToDouble(values[1]);
    C = Convert.ToDouble(values[2]);

    delta = B * B - 4 * A * C;

    R1 = -B + Math.Sqrt(delta) / (2 * A);
    R2 = -B - Math.Sqrt(delta) / (2 * A);

    if (A == 0 || delta < 0.0)
      Console.WriteLine("Impossivel calcular");
    else
      Console.WriteLine("R1 = {0:F5}", R1);
    Console.WriteLine("R2 = {0:F5}", R2);

  }
}
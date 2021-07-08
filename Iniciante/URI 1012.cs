using System;

class URI
{

  public static void Main(string[] args)
  {

    double A, B, C, pi;
    double tri, cir, tra, qua, ret;

    string line1 = Console.ReadLine();

    string[] values = line1.Split(' ');
    A = Convert.ToDouble(values[0]);
    B = Convert.ToDouble(values[1]);
    C = Convert.ToDouble(values[2]);
    pi = 3.14159;

    tri = (A * C) / 2;
    cir = pi * Math.Pow(C, 2);
    tra = ((A + B) * C) / 2;
    qua = B * B;
    ret = A * B;

    Console.WriteLine("TRIANGULO: {0:F3}", tri);
    Console.WriteLine("CIRCULO: {0:F3}", cir);
    Console.WriteLine("TRAPEZIO: {0:F3}", tra);
    Console.WriteLine("QUADRADO: {0:F3}", qua);
    Console.WriteLine("RETANGULO: {0:F3}", ret);
  }
}
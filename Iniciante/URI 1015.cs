using System;

class URI
{

  public static void Main(string[] args)
  {

    double x1, y1, x2, y2, distancia;

    string line1 = Console.ReadLine();
    string line2 = Console.ReadLine();

    string[] values1 = line1.Split(' ');
    x1 = Convert.ToDouble(values1[0]);
    y1 = Convert.ToDouble(values1[1]);

    string[] values2 = line2.Split(' ');
    x2 = Convert.ToDouble(values2[0]);
    y2 = Convert.ToDouble(values2[1]);

    distancia = (Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)));

    Console.WriteLine("{0:F4}", distancia);

  }
}
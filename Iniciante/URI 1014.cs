using System;

class URI
{

  public static void Main(string[] args)
  {

    int distancia;
    double cgasto, media;

    distancia = Int32.Parse(Console.ReadLine());
    cgasto = Double.Parse(Console.ReadLine());

    media = distancia / cgasto;

    Console.WriteLine("{0:F3} km/l", media);

  }
}
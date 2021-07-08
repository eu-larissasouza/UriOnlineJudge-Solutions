using System;

class URI
{

  public static void Main(string[] args)
  {
    int N, hr, min, seg;

    N = Int32.Parse(Console.ReadLine());

    hr = N / 3600;
    N -= (hr * 3600);

    min = N / 60;
    N -= (min * 60);

    seg = N;

    Console.WriteLine(hr + ":" + min + ":" + seg);

  }
}
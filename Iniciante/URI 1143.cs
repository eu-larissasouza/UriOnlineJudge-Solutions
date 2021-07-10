using System;

class URI {

  public static void Main(string[] args) {

    int a, b, c, d, e, f;

    a = Int32.Parse(Console.ReadLine());

    for (b = 1; b <= a; b++) {
      c = b * b;
      d = b * b * b;
      Console.WriteLine(b + " " + c + " " + d);
    }

  }
}
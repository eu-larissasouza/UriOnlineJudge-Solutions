using System;

class URI {

  public static void Main(string[] args) {

    double X, Y;

    string line = Console.ReadLine();

    string[] values = line.Split(' ');
    X = Convert.ToDouble(values[0]);
    Y = Convert.ToDouble(values[1]);

    if (X == 0.0 && Y == 0.0) {
      Console.WriteLine("Origem");
    } else {
      if (X == 0.0) {
        Console.WriteLine("Eixo Y");
      } else {
        if (Y == 0.0) {
          Console.WriteLine("Eixo X");
        } else {
          if (X > 0.0 && Y > 0.0) {
            Console.WriteLine("Q1");
          } else {
            if (X < 0.0 && Y > 0.0) {
              Console.WriteLine("Q2");
            } else {
              if (X < 0.0 && Y < 0.0) {
                Console.WriteLine("Q3");
              } else {
                if (X > 0.0 && Y < 0.0) {
                  Console.WriteLine("Q4");
                }
              }
            }
          }
        }
      }
    }

  }
}
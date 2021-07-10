using System;

class URI {

  public static void Main(string[] args) {
    int cont, num;
    num = Int32.Parse(Console.ReadLine());

    if (num % 2 == 0)
      num = num + 1;
    else
      num = num;
    Console.WriteLine(num);
    for (cont = 1; cont <= 5; cont++)
      Console.WriteLine("{0}", num += 2);

  }
}
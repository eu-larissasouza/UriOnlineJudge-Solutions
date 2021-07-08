using System;

class URI
{

  public static void Main(string[] args)
  {

    short cod, quant;
    double total;

    string line1 = Console.ReadLine();

    string[] values1 = line1.Split(' ');
    cod = Int16.Parse(values1[0]);
    quant = Int16.Parse(values1[1]);

    if (cod == 1)
    {
      total = quant * 4.00;
      Console.WriteLine("Total: R$ {0:F2}", total);
    }
    else if (cod == 2)
    {
      total = quant * 4.50;
      Console.WriteLine("Total: R$ {0:F2}", total);
    }
    else if (cod == 3)
    {
      total = quant * 5.00;
      Console.WriteLine("Total: R$ {0:F2}", total);
    }
    else if (cod == 4)
    {
      total = quant * 2.00;
      Console.WriteLine("Total: R$ {0:F2}", total);
    }
    else if (cod == 5)
    {
      total = quant * 1.50;
      Console.WriteLine("Total: R$ {0:F2}", total);
    }

  }
}
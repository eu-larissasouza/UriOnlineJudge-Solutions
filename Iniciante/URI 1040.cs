using System;

class URI
{

  public static void Main(string[] args)
  {

    double n1, n2, n3, n4, media, exame, mediafinal;

    string line = Console.ReadLine();

    string[] values = line.Split(' ');
    n1 = Convert.ToDouble(values[0]);
    n2 = Convert.ToDouble(values[1]);
    n3 = Convert.ToDouble(values[2]);
    n4 = Convert.ToDouble(values[3]);

    media = (n1 * 0.2 + n2 * 0.3 + n3 * 0.4 + n4 * 0.1);

    Console.WriteLine("Media: {0}", media.ToString("#0.0"));

    if (media >= 7)
    {
      Console.WriteLine("Aluno aprovado.");
    }
    else if (media < 7 && media >= 5)
    {
      Console.WriteLine("Aluno em exame.");

      exame = Double.Parse(Console.ReadLine());

      Console.WriteLine("Nota do exame: {0}", exame.ToString("#0.0"));

      mediafinal = (media + exame) / 2;

      if (mediafinal >= 5)
      {
        Console.WriteLine("Aluno aprovado.");
      }
      else
      {
        Console.WriteLine("Aluno reprovado.");
      }
      Console.WriteLine("Media final: {0}", mediafinal.ToString("#0.0"));
    }
    else
    {
      Console.WriteLine("Aluno reprovado.");
    }

  }
}
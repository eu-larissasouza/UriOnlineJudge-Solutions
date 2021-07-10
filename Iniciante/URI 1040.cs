using System;

class URI
{

  public static void Main(string[] args){
    double a, b, c, d, last, m;
    
    a = Double.Parse(Console.ReadLine());
    b = Double.Parse(Console.ReadLine());
    c = Double.Parse(Console.ReadLine());
    d = Double.Parse(Console.ReadLine());

    m = (a * 2 + b * 3 + c * 4 + d) / 10;

    Console.Write("Media: {0:F1}\n", m);

    if (m >= 7.0)
    {
        Console.Write("Aluno aprovado.\n");
    }
    else if (m >= 5.0)
    {
        Console.Write("Aluno em exame.\n");
        last = Double.Parse(Console.ReadLine());

        Console.Write("Nota do exame: {0:F1}\n", last);
        if (last + m / 2.0 > 5.0)
        {
            Console.Write("Aluno aprovado.\n");
        }
        else
        {
            Console.Write("Aluno reprovado.\n");
        }
        Console.Write("Media final: {0:F1}\n", (last + m) / 2.0);
    }
    else
    {
        Console.Write("Aluno reprovado.\n");
    }
}
}
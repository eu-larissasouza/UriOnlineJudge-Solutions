using System;

class URI
{

  public static void Main(string[] args)
  {

    int dia, ano, mes;

    dia = Int32.Parse(Console.ReadLine());

    ano = dia / 365;
    dia -= (ano * 365);

    mes = dia / 30;
    dia -= (mes * 30);

    Console.WriteLine(ano + " ano(s)");
    Console.WriteLine(mes + " mes(es)");
    Console.WriteLine(dia + " dia(s)");

  }
}
using System; 

class URI {

    public static void Main(string[] args) { 

        string nome;
        double salario, montante, lucro, total;
        
        nome = Console.ReadLine();
        
        salario = Double.Parse(Console.ReadLine());
        montante = Double.Parse(Console.ReadLine());
        
        lucro = 0.15 * montante;
        
        total = salario + lucro;
        
        Console.WriteLine("TOTAL = R$ {0:F2}", total);
        
    }
}
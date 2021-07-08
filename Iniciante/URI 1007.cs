using System; 

class URI {

    public static void Main(string[] args) { 
        
        int A, B, C, D, DIFERENCA;
        
        A = Int32.Parse(Console.ReadLine());
        
        B = Int32.Parse(Console.ReadLine());
        
        C = Int32.Parse(Console.ReadLine());
        
        D = Int32.Parse(Console.ReadLine());
        
        DIFERENCA = (A * B - C * D);
        
        Console.WriteLine("DIFERENCA = {0}", DIFERENCA);

    }
}
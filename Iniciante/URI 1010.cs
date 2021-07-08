using System; 

class URI {

    public static void Main(string[] args) { 

        double result;
        
        string line1 = Console.ReadLine();
        string line2 = Console.ReadLine();
        
        string[] values1 = line1.Split(' ');
        int c1 = Int32.Parse(values1[0]);
        int n1 = Int32.Parse(values1[1]);
        double v1 = Convert.ToDouble(values1[2]);
        
        string[] values2 = line2.Split(' ');
        int c2 = Int32.Parse(values2[0]);
        int n2 = Int32.Parse(values2[1]);
        double v2 = Convert.ToDouble(values2[2]);
    
        result= (n1*v1) + (n2*v2);
        
        Console.WriteLine("VALOR A PAGAR: R$ {0:F2}", result);
    }
}
using System; 

class URI {

    public static void Main(string[] args) { 
        
        double pi = 3.14159;

        double raio, area;
        
        raio = Double.Parse(Console.ReadLine());
        
        area = pi * Math.Pow(raio, 2);
        
        Console.WriteLine("A={0:F4}", area);
        
    }
}
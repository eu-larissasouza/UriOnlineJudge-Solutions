using System; 

class URI {

    public static void Main(string[] args) { 

        double A, B, C, MEDIA;
        
        A = Double.Parse(Console.ReadLine());
        
        B = Double.Parse(Console.ReadLine());
        
        C = Double.Parse(Console.ReadLine());
        
        MEDIA= (A*0.2 + B*0.3 + C*0.5);
        
        Console.WriteLine("MEDIA = {0:F1}", MEDIA);
    }
}
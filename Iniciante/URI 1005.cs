using System; 

class URI {

    public static void Main(string[] args) { 

        double A, B, MEDIA;
        
        A = Double.Parse(Console.ReadLine());
        
        B= Double.Parse(Console.ReadLine());
        
        MEDIA = (A*3.5 + B*7.5)/11;
        
        Console.WriteLine("MEDIA = {0:F5}", MEDIA);
    }
}
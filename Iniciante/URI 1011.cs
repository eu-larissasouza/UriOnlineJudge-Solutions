using System; 

class URI {

    public static void Main(string[] args) { 

        double pi, volume;
        short R;
        
        R= Int16.Parse(Console.ReadLine());
        pi= 3.14159;
        
        volume= (4/3.0) * pi * Math.Pow(R, 3);
        
        Console.WriteLine("VOLUME = {0:F3}", volume);
    }
}
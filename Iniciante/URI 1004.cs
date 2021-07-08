using System; 

class URI {

    public static void Main(string[] args) { 

        int A, B, PROD;
        
        A = Int32.Parse(Console.ReadLine());
        B = Int32.Parse(Console.ReadLine());
        
        PROD= A*B;
        
        Console.WriteLine("PROD = {0}", PROD);
        
    }
}
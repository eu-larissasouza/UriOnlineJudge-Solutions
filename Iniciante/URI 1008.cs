using System; 

class URI {

    public static void Main(string[] args) { 
        
        int NUMBER, TIME;
        double SALARY, AUX;
        
        NUMBER = Int32.Parse(Console.ReadLine());
        TIME = Int32.Parse(Console.ReadLine());
        AUX = Double.Parse(Console.ReadLine());
        
        SALARY= (AUX * TIME);
        
        Console.WriteLine("NUMBER = {0}", NUMBER);
        Console.WriteLine("SALARY = U$ {0:F2}", SALARY);

    }
}
namespace FirstProgram;
using System;
class Program
{
    static void Main(string[] args)
    {
        int num1 = 0;
        int num2 = 0;
        num1 = Convert.ToInt32(Console.ReadLine());
        num2 = Convert.ToInt32(Console.ReadLine());

        if(num1 == num2) {
            Console.WriteLine($"Right");
        } else if(num1 < num2) {
            Console.WriteLine($"to high");
        } else {
            Console.WriteLine($"to low");
        }
    
    }
}
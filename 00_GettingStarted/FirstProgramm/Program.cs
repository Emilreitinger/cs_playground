namespace FirstProgram
{
    using System;

    class Program
    {
        static void guess()
        {
            int num1 = 0;
            int num2 = 0;

            Console.WriteLine("Number:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Guess:");
            for (int i = 0; i < 10; i++)
            {
                num2 = Convert.ToInt32(Console.ReadLine());
                if (num1 == num2)
                {
                    Console.WriteLine("Right");
                    break;
                }
                else if (num1 < num2) {
                    Console.WriteLine("Too high");
                }
                else {
                    Console.WriteLine("Too low");
                }
            }
        }


        static void Main(string[] args)
        {

            guess();
        }
    }
}
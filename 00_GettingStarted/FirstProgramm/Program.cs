using System;

namespace FirstProgram
{
    class Program 
    {
        static void Main(string[] args) {
            // 1) Variablen und Datentypen
            int alter;
            alter = 20;
            Console.WriteLine(alter);

            // 2) Mathematische Rechnungen
            int number1 = 10;
            int number2 = 20;
            Console.WriteLine(number1 * number2);
            Console.WriteLine(number1 % number2);
            
            // 3) If
            int age = 10;
            if (age >= 18) {
                Console.WriteLine("Old");
            } else {
                Console.WriteLine("Young");
            }

            // 4) Switch
            int year = 6;
            switch (year) {
                case 1:
                    Console.WriteLine("Januar");
                    break;
                case 2:
                    Console.WriteLine("Februar");
                    break;
                default:
                    Console.WriteLine("Another month");   
                    break;
            }

            // 5) While - Do While
            while (number1 == 10) {
                Console.WriteLine("number == 10");
                number1++;
            }

            do {
                Console.WriteLine("smaller than 10");
            } while (number1 < 10);

            // for Schleife
            for (int i = 0; i < number1; i++) {
                Console.WriteLine(i);
            }

            // array D1
            int[] arr = new int[3];
            arr[0] = 10;
            arr[1] = 20;
            arr[2] = 30;
            Console.WriteLine("number: " + arr[0]);

            // array D2
            string[,] arr2 = new string[2, 2];
            arr2[0, 0] = "Emil";
            arr2[0, 1] = "1";
            arr2[1, 0] = "Teuerman";
            arr2[1, 1] = "5";
            Console.WriteLine(arr2[0, 0] + " " + arr2[0, 1]);
        }
    }
}
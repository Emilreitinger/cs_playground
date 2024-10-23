using System;
using System.Collections.Generic; //für List

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

            // 6) for Schleife
            for (int i = 0; i < number1; i++) {
                Console.WriteLine(i);
            }

            // 7) array D1
            int[] arr = new int[3];
            arr[0] = 10;
            arr[1] = 20;
            arr[2] = 30;
            Console.WriteLine("number: " + arr[0]);

            // 8) array D2
            string[,] arr2 = new string[2, 2];
            arr2[0, 0] = "Emil";
            arr2[0, 1] = "1";
            arr2[1, 0] = "Teuerman";
            arr2[1, 1] = "5";
            for(int i = 0; i < arr2.GetLength(0); i++) {
                for(int j = 0;  j < arr2.GetLength(1); j++) {
                    Console.Write(arr2[i, j]+ " ");
                }
                Console.WriteLine();    
            }

            //9) List & foreach
            List<string> food = new List<string>();
            food.Add("burger");
            food.Add("pizza");
            food.Add("soup");
            food.Add("Chicken");

            foreach(string item in food) {
                Console.WriteLine(item);
            }
        }
    }
}
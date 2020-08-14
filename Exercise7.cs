using System;

namespace third_exercises_csharp_entra21
{
    public class Exercise7
    {
        public static void ValuedEqualPlacedInArray()
        {
            double[] vect;
            var match = 0;
            Console.WriteLine("quantos numeros queres inserir? ");
            int inputIndex = Int32.Parse(Console.ReadLine());
            vect = new double[inputIndex];
            for (int i = 0; i < vect.Length; i++)
            {
                Console.WriteLine("Digit a number: ");
                while (true)
                {
                    try
                    {
                        vect[i] = Double.Parse(Console.ReadLine());
                        break;
                    }
                    catch (System.Exception)
                    {
                        Console.WriteLine("Insert only numbers!! Try again!");
                    }
                }
                match = (vect[i] == i) ? match += 1 : match;
            }

            System.Console.WriteLine($"Há {match} numeros na mesma posição dos seus valores.");

        }
    }
}
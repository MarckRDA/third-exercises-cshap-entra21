using System;

namespace third_exercises_csharp_entra21
{
    public class Exercise4
    {
        public static void SumBetweenAAndBArray()
        {
            var vect = new double[10];
            var sum = 0.0;
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
                sum = (vect[i] % 2 != 0) ? sum += vect[i] : sum;

            }

            Console.WriteLine($"The sum of impars values is {sum}");
        }
    }
}
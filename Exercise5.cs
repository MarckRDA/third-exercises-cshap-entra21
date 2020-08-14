using System;

namespace third_exercises_csharp_entra21
{
    public class Exercise5
    {
        public static void CountPositivePositions()
        {
            var vect = new double[10];
            var positiveNumbers = 0;

            for (int i = 0; i < vect.Length; i++)
            {
                System.Console.WriteLine("Digit a number: ");
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
                positiveNumbers = (vect[i] > 0) ? positiveNumbers += 1 : positiveNumbers;
            }
            System.Console.WriteLine($"It's {positiveNumbers} positive numbers in this vector");
        }
    }
}
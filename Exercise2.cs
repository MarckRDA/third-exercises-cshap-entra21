using System;

namespace third_exercises_csharp_entra21
{
    public class Exercise2
    {
        public static void IsThereARepeatedNumberInArray()
        {
            double[] vect = new double[10];
            var thereIsARepeatedNumber = false;
            for (int i = 0; i < vect.Length; i++)
            {
                Console.WriteLine($"Digit the {i + 1}º number: ");
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

            }
            for (int i = 0; i < vect.Length; i++)
            {
                for (int j = i; j < vect.Length; j++)
                {
                    if (i != j && vect[i] == vect[j])
                    {
                        thereIsARepeatedNumber = true;
                        break;
                    }
                }
                if (thereIsARepeatedNumber)
                {
                    break;
                }
            }

            var messager = (thereIsARepeatedNumber) ? "There's a repeated number!" : "There's not a repeated number!";

            Console.WriteLine(messager);
        }
    }
}
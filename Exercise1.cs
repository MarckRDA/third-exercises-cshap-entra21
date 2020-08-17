using System;

namespace third_exercises_csharp_entra21
{
    public class Exercise1
    {

        public static void TwistedArrays()
        {
            const int arrayLength = 5;
            double[] vectA = new double[arrayLength];
            double[] vectB = new double[arrayLength];
            double[] auxiliarVect = new double[arrayLength];
            

            for (int i = 0; i < arrayLength; i++)
            {
                Console.WriteLine($"Digit the {i + 1}º number in vector A: ");
                while (true)
                {
                    try
                    {
                        vectA[i] = Double.Parse(Console.ReadLine());
                        break;
                    }
                    catch (System.Exception)
                    {
                        Console.WriteLine("Insert only numbers!! Try again!");
                    }
                }
                auxiliarVect[i] = vectA[i];

            }

            for (int i = 0; i < arrayLength; i++)
            {
                Console.WriteLine($"Digit the {i + 1}º number in vector B: ");
                while (true)
                {
                    try
                    {
                        vectB[i] = Double.Parse(Console.ReadLine());
                        break;
                    }
                    catch (System.Exception)
                    {
                        Console.WriteLine("Insert only numbers!! Try again!");
                    }
                }
                vectA[i] = vectB[i];
            }

            for (int i = 0; i < arrayLength; i++)
            {
                vectB[i] = auxiliarVect[i];
            }
            Console.WriteLine(string.Join(", ", vectA));
            Console.WriteLine(string.Join(", ", vectB));
        }

    }
}
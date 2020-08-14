using System;

namespace third_exercises_csharp_entra21
{
    public class Exercise8
    {
        public static void VogalVectorCount()
        {
            string[] vect = new string[10];
            var countVogal = 0;

            for (int i = 0; i < vect.Length; i++)
            {
                Console.WriteLine("Insira uma letra");
                vect[i] = Console.ReadLine().ToLower();

                if (vect[i] == "a" || vect[i] == "e" || vect[i] == "i" || vect[i] == "o" || vect[i] == "u")
                {
                    countVogal++;
                }
            }
            System.Console.WriteLine($"Há {countVogal} vogais no vetor");
        }
    }
}
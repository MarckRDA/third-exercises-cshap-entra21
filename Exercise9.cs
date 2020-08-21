using System;

namespace third_exercises_csharp_entra21
{
    public class Exercise9
    {
        public static void SumStrings()
        {
            string[] vect = new string[10];
            var biultString = "";
            for (int i = 0; i < vect.Length; i++)
            {
                Console.WriteLine("Digit a word: ");
                vect[i] = System.Console.ReadLine();
                biultString = (i % 2 == 0) ? biultString += vect[i] : biultString;
            }
            Console.WriteLine(biultString);
            
        }
    }
}
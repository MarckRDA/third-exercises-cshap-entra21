using System;

namespace third_exercises_csharp_entra21
{
    public class Exercise6
    {
        public static void BiggestNumberInArray()
        {
            double[] vect = new double[10];
            (double value, int position, int flag) biggestNumber = (0.0, 0, 0);
            var positiveNumber = 0.0;

            for (int i = 0; i < vect.Length; i++)
            {
                System.Console.WriteLine("Digit a number: ");
                while (true)
                {
                    try
                    {
                        positiveNumber = Double.Parse(Console.ReadLine());
                        if (positiveNumber < 0)
                        {
                            Console.WriteLine("Insert only positive numbers!! Try again!");
                            continue;
                        }
                        else
                        {
                            vect[i] = positiveNumber;
                            break;
                        }
                    }
                    catch (System.Exception)
                    {
                        Console.WriteLine("Insert only numbers!! Try again!");
                    }
                }

            }

            for (int i = 0; i < vect.Length; i++)
            {
                for (int j = 0; j < vect.Length; j++)
                {
                    if (vect[i] > vect[j])
                    {
                        biggestNumber.value = vect[i];
                        biggestNumber.position = i;
                        biggestNumber.flag++;
                    }
                }
                if (biggestNumber.flag == vect.Length - 1)
                {
                    break;
                }
                biggestNumber.flag = 0;
            }

            Console.WriteLine($"O valor {biggestNumber.value} esta na posicão {biggestNumber.position}");

        }
    }
}
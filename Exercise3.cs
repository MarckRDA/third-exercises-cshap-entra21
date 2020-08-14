using System;

namespace third_exercises_csharp_entra21
{
    public class Exercise3
    {
         public static void MaleOrFemaleResearch()
        {
            const int interviwers = 5;
            (int woman, int answerYes, int answerNo) woman = (0, 0, 0);
            (int man, int answerYes, int answerNo) man = (0, 0, 0);

            for (int i = 0; i < interviwers; i++)
            {
                var optionSex = 0;
                var optionLike = 0;
                System.Console.WriteLine("Are you a man or woman ?  Type 1 - for man / 2 for woman ");
                while (true)
                {
                    try
                    {
                        optionSex = Int32.Parse(Console.ReadLine());
                        break;
                    }
                    catch (System.Exception)
                    {

                        Console.WriteLine("Insert only numbers!! Try again!");
                    }
                }
                Console.WriteLine("do you like our product? 1)yes    2)no");
                while (true)
                {
                    try
                    {
                        optionLike = Int32.Parse(Console.ReadLine());
                        break;
                    }
                    catch (System.Exception)
                    {
                        Console.WriteLine("Insert only numbers!! Try again!");
                    }
                }
                if (optionSex == 1)
                {
                    man.man++;
                    if (optionLike == 1)
                    {
                        man.answerYes++;
                    }
                    else
                    {
                        man.answerNo++;
                    }
                }
                else
                {
                    woman.woman++;
                    if (optionLike == 1)
                    {
                        woman.answerYes++;
                    }
                    else
                    {
                        woman.answerNo++;
                    }
                }
            }

            System.Console.WriteLine($"{woman.answerYes + man.answerYes} people answered yes.");
            System.Console.WriteLine($"{woman.answerNo + man.answerNo} people answered no.");
            System.Console.WriteLine($"{(woman.answerYes / woman.woman) * 100}% of women answered yes.");
            System.Console.WriteLine($"{(man.answerNo / man.man) * 100}% of men answered no.");
        }
    }
}
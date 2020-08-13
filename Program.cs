using System;

namespace third_exercises_csharp_entra21
{
    class Program
    {
        //Exercise 1
        static void Exercise1()
        {
            const int arrayLength = 10;
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
        }
        static void Exercise2()
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

        static void Exercise3()
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

        static void Exercise4()
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

        static void Exercise5()
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

        static void Exercise6()
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

        static void Exercise7()
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

        static void Exercise8()
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

        static void Exercise9()
        {
            string[] vect = new string[10];
            var biuldString = "";
            for (int i = 0; i < vect.Length; i++)
            {
                Console.WriteLine("Digit a word: ");
                vect[i] = System.Console.ReadLine();
                biuldString = (i % 2 == 0) ? biuldString += vect[i] : biuldString;
            }
            Console.WriteLine(biuldString);
        }

        static void Main(string[] args)
        {
            Exercise9();
        }
    }
}

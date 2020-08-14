using System;

namespace third_exercises_csharp_entra21
{
    class Menu
    {    
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha o exercício de 1-9 de interesse: ");

            while(true)
            {
                var option = Console.ReadLine();

                switch(option){
                    case "1":
                        Exercise1.TwistedArrays();
                        break;
                    case "2":
                        Exercise2.IsThereARepeatedNumberInArray();
                        break;
                    case "3":
                        Exercise3.MaleOrFemaleResearch();
                        break;
                    case "4":
                        Exercise4.SumBetweenAAndBArray();
                        break;
                    case "5":
                        Exercise5.CountPositivePositions();
                        break;
                    case "6":
                        Exercise6.BiggestNumberInArray();
                        break;
                    case "7":
                        Exercise7.ValuedEqualPlacedInArray();
                        break;
                    case "8":
                        Exercise8.VogalVectorCount();
                        break;
                    case "9":
                        Exercise9.SumStrings();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}

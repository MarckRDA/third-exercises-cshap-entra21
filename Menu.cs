using System;

namespace third_exercises_csharp_entra21 {
    class Menu {
        static void Main (string[] args) {
            while (true) {
                Console.WriteLine ("Escolha o exercício de 1-9 de interesse:  Pressione Ctrl + C para sair");
                var option = Console.ReadLine ();

                if (option == "1") {
                    Exercise1.TwistedArrays ();
                    continue;
                } else if (option == "2") {
                    Exercise2.IsThereARepeatedNumberInArray ();
                    continue;
                } else if (option == "3") {
                    Exercise3.MaleOrFemaleResearch ();
                    continue;
                } else if (option == "4") {
                    Exercise4.SumBetweenAAndBArray ();
                    continue;
                } else if (option == "5") {
                    Exercise5.CountPositivePositions ();
                    continue;
                } else if (option == "6") {
                    Exercise6.BiggestNumberInArray ();
                    continue;
                } else if (option == "7") {
                    Exercise7.ValuedEqualPlacedInArray ();
                    continue;
                } else if (option == "8") {
                    Exercise8.VogalVectorCount ();
                    continue;
                } else if (option == "9") {
                    Exercise9.SumStrings ();
                    continue;
                } else {
                    Console.WriteLine ("Escolha o número correto, por favor!");
                    continue;
                }

            }
        }
    }
}

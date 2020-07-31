using System;

namespace third_exercises_csharp_entra21
{
    class Program
    {   
        //Exercise 1
        static void SwichVects(string[] args)
        {
            int [] vectA = new int[10];
            int [] vectB = new int [10];
            int [] auxiliarVect = new int[10];
            var count = 0;

            while (count < 10)
            {
                System.Console.WriteLine("Digit the {0}º number in the A vector: ", count+1);
                vectA[count] = Convert.ToInt32(System.Console.ReadLine());
                count++;
            }

            count =0;

            while (count < 10)
            {
                System.Console.WriteLine("Digit the {0}º number in the B vector: ", count+1);
                vectB[count] = Convert.ToInt32(System.Console.ReadLine());
                count++;
            }
            Array.Copy(vectA, auxiliarVect, 10);
            Array.Copy(vectB, vectA, 10);
            Array.Copy(auxiliarVect, vectB, 10);
            System.Console.WriteLine(string.Join(" ", vectA));
            System.Console.WriteLine(string.Join(" ", vectB));
        }

        //Exercise 2
        public static void Main() 
        {
           int[] vect = {1,2,3,3,4,5,6,7,9,10};
           var count = 0;
           var flag = 0;
           
           while (count < 10){
           	var i = 0;
           	while (i< 9){
           		if (vect[count]==vect[i+1]){
           			System.Console.WriteLine("tem");
           			flag++;
           			break;
           		}
           		else if (i == 9){
           			System.Console.WriteLine("nao tem");
           			
           		}
           		i++;
           	}
           	count++;
           	if(flag > 0){
           		break;
           	}
           	
           }
        }

        //Exercise 3
        static void SearchProduct(string[] args)
        {
           var man = 0.0;
           var woman = 0.0;
           var manNo = 0.0;
           var manYes = 0.0;
           var womanNo = 0.0;
           var womanYes = 0.0;
           var count = 0.0;

           while (count < 10){
                System.Console.WriteLine("Are you a man or woman ?  Type 1 - for man/ 2 for woman ");
                var optionSex = Convert.ToDouble(System.Console.ReadLine());
                System.Console.WriteLine("do you like our product? 1)yes    2)no");
                var optionLike = Convert.ToDouble(System.Console.ReadLine());

                if (optionSex == 1){
                    man++;
                    if (optionLike == 1){
                        manYes++;
                    }
                    else{
                        manNo++;
                    }
                }
                else{
                    woman++;
                    if (optionLike == 1){
                        womanYes++;
                    }
                    else{
                        womanNo++;
                    }
                }

                count++;
            }
            System.Console.WriteLine("{0} people answered yes.", womanYes+manYes);
            System.Console.WriteLine("{0} people answered no.", womanNo+manNo);
            System.Console.WriteLine("{0}% of women answered yes.", (womanYes/woman)*100);
            System.Console.WriteLine("{0}% of men answered no.", (manNo/man)*100);
        }

        //Exercise 4
        static void SumOfImparesNumbers(string[] args)
        {
            var vect = new double [5];
            var count = 0;
            var sum = 0.0;

            while (count < 5)
            {
                System.Console.WriteLine("Digit a number: ");
                vect[count] = Convert.ToDouble(System.Console.ReadLine());
                if (vect[count] % 2 !=0){
                    sum +=vect[count];
                }
                count++;
            }
            System.Console.WriteLine("The sum of impars values is {0}", sum);
        }

        //Exercise 5
        static void PositiveNumbers(string[] args)
        {
            var vect = new int [10];
            var count = 0;
            var sum = 0;

            while (count < 10)
            {
                System.Console.WriteLine("Digit a number: ");
                vect[count] = Convert.ToInt32(System.Console.ReadLine());
                if (vect[count] > 0){
                    sum++;
                }
                count++;
            }
            System.Console.WriteLine("It's {0} positive numbers in this vector", sum);
        }

        //Exercise 6
       static void PositionInTheVect(string[] args) 
        {
           int [] vect = new int [10];
           var count = 0;
           var auxiliar = 0;
           var match = 0;
           
           while(count < 10){
           	System.Console.WriteLine("Digite um numero");
           	var input = Convert.ToInt32(System.Console.ReadLine());
           	if(input < 0){
           		System.Console.WriteLine("Insira somente numeros positivos!");
           		continue;
           	}
           	else{
           		vect[count] = input;
           	}
           	count++;
           }
           count = 0;
           
           while (count < 10){
           		int i =0;
           		while(i < 10){
           			if(vect[count] > vect[i]){
           				match++;
           			}
           			if(match == 9){
           				auxiliar = count;
           				break;
           			}
           			i++;
           		}
           		count++;
           		match =0;
           }
           Console.WriteLine("O valor {0} esta na posicão {1}", vect[auxiliar], auxiliar);
           
        }

        //Exercise 7
         static void SamePositionAndValue(string[] args)
        {
           int [] vect;
           var count = 0;
           var match = 0;
           System.Console.WriteLine("quantos numeros queres inserir? ");
           var index = Convert.ToInt32(System.Console.ReadLine());
           vect = new int [index];
           while(count < index){
				System.Console.WriteLine("Insira um numero");
				vect[count] = Convert.ToInt32(System.Console.ReadLine());
				if(vect[count]==count){
					match++;
				}
				count++;
           }
           System.Console.WriteLine("Há{0} numeros na mesma posição dos seus valores.", match);
           
        }

        //Exercise 8

         static void VogalsInVect(string[] args) 
        {
           string [] vect = new string[10];
           var count = 0;
           var countVogal= 0;
           
           while (count < 10){
           	System.Console.WriteLine("Insira uma letra");
           	vect[count] = System.Console.ReadLine().ToLower();
           	if (vect[count]=="a" ||vect[count]=="e"|| vect[count]=="i"||vect[count]=="o"||vect[count]=="u"){
           		countVogal++;
           	}
           	count++;
           }
           System.Console.WriteLine("Há {0} vogais no vetor", countVogal);
        }

        //Exercise 9

         static void EvenInVect(string[] args) 
        {
           string [] vect = new string[10];
           var count = 0;
           
           while(count <10){
           	System.Console.WriteLine("Digite uma letra: ");
           	vect[count] = System.Console.ReadLine();
           	count++;
           }
           count = 0;
           while(count < 10){
           	if(count % 2 == 0){
           		System.Console.WriteLine(vect[count]);
           		
           	}
           	count++;
           }
    }
}

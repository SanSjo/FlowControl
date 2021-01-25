using System;
using System.Collections.Generic;

namespace Övning2
{
    class Program
    {

        static void Main(string[] args)
        {
            MainMenu();

            string input = Console.ReadLine();
            int.Parse(input);
            bool success = false;

            do
            {
                switch (input)
                {
                    case "0":
                        Environment.Exit(0);
                        break;
                    case "1":
                        JuniorOrSenior();
                        TicketOrder();
                        break;
                    case "2":
                        PrintTenTimes();
                        break;
                    case "3":
                        PrintWordThree();
                        break;
                    default:
                        Console.WriteLine("Fel inmatning");
                        break;
                }
            } while (success);


            static void JuniorOrSenior()
            {
                Console.WriteLine("Hur gammal är du?");

                string age = Console.ReadLine();
                int answerAge;
                int.TryParse(age, out answerAge);

                if (answerAge <= 20)
                {
                    Console.WriteLine("Ungdomspris 80kr");

                }
                else if (answerAge >= 64)
                {
                    Console.WriteLine("Pensionärspris 90kr");
                }
                else
                {
                    Console.WriteLine("Standardpris 120kr");
             
                }

            }

        }


        // Method to make an order with different ages and get the total cost for the order
        private static void TicketOrder()
        {
            Console.WriteLine("Hur många biljettr vill du ha?");
            string amount = Console.ReadLine();
            int.TryParse(amount, out int tickets);
            Console.WriteLine($"Du vill beställa {amount} biljetter, hur gamla är alla?");

            int age;
            int sum = 0;
            int agePrice;
            for (int i = 0; i < tickets; i++)
                {
               
                string ageInput = Console.ReadLine();
                int.TryParse(ageInput, out age);

                if (age <= 20)
                {
                    agePrice = 80;
                  
                }
                else if (age >= 65)
                {
                    agePrice = 90;
                }
                else
                {
                    agePrice = 120;
                }

                sum += agePrice;

            }

            Console.WriteLine($"Totala priset för alla är " + sum + " kr.");

        }

        private static void PrintWordThree()
        {
            Console.WriteLine("Ange en mening med minst 3 ord");
            string printSentence = Console.ReadLine();
            string[] words = printSentence.Split(" ");

            foreach (var item in words)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine($"Tredje ordet i meningen är " + words[2]);
        }


        private static void MainMenu()
        {
            Console.WriteLine("Ni komer få tre olika val");
            Console.WriteLine("1. Ungdom eller pensionär?");
            Console.WriteLine("2. Upprepa tio gånger");
            Console.WriteLine("2. Det tredje ordet");
            Console.WriteLine("3. Avsluta");
        }

        private static void PrintTenTimes()
        {
            Console.WriteLine("Skriv in något och få tillbaka det 10 gånger");
            string input = Console.ReadLine();

            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i+ ". " + input + ", ");
            }
        }
    }
}

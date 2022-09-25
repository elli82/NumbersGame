using System;
using System.Threading;

namespace NumbersGame   // Elin Linderholm SUT22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();  // anropar metoden Random för att slumpa fram ett nummer mellan 1-20
            int number = random.Next(21);
                        
            Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök!");
           
                CheckGuesses(number);  // anropar metoden CheckGuesses för att kontrollera de gissade numren mot det slumpade   
        }
        
        public static void CheckGuesses(int number)  //skapar min metod CheckGuesses
        {            
            int guesses = 0;            
          
           for (int i=0; i<5; i++)  // en loop som håller koll på antalet gissningar, max fem försök
            {
                Console.WriteLine("Vilken siffra gissar du på?");
                int tries = Convert.ToInt32(Console.ReadLine());

                if (tries < number)
                {
                    Console.WriteLine("Tyärr du gissade för lågt.");    //om man gissar för lågt               
                }
                else if (tries > number)
                {
                    Console.WriteLine("Tyvärr du gissade för högt.");   //om man gissar för högt                 
                }
                else if (tries == number)                    // om man gissar rätt, och då avslutas programmet
                {
                    Console.WriteLine("Woho! Du gjorde det!");                    
                    break;
                }
                guesses++;                          // för att räkna antalet gissningar

                if (guesses == 5)                   // vid fem gissningar avslutas programmet
                {
                    Console.WriteLine("Tyvärr, du lyckades inte gissa talet på fem försök.");
                    break;
                }
            }           
        }
    }
}

       

            







            

    


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array._7
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 7.Skapa ett program där användaren får mata in en inköpslista. 
             * Börja med att fråga användaren hur många varor den skall ha på sin lista.
             * Gör en loop som gås igenom det antal gånger som användaren angivit.
             * Inne i loopen skall tre frågor anges - Vilken vara som användaren vill lägga till-Vilket pris varan har – Vilket produktnummer.
                Spara alla dessa värden i en array.Loopa sedan igenom arrayen och skriv ut alla varor som användaren har angivit med alla uppgifter på skärmen. 
                 */

            Console.Write("Hur många varor på inköpslista: ");
            int antalVaror = Convert.ToInt32(Console.ReadLine());
            
            string[] varan = new string[antalVaror];
            decimal[] prisvaran = new decimal[antalVaror];
            int[] produktnummer = new int[antalVaror];


            
                for(int i = 0; i < antalVaror; i++)
                {
                    Console.Write("Vilken vara: ");
                    varan[i] = Console.ReadLine();

                    Console.Write($"Vilket pris har {varan[i]}: ");
                    prisvaran[i] = Convert.ToDecimal(Console.ReadLine());
                    Console.Write($"Vilket produkt nummer har {varan[i]}: ");
                    produktnummer[i] = Convert.ToInt32(Console.ReadLine());

                }
            for (int i = 0; i < antalVaror; i++)
            {
                Console.WriteLine($"Varan {varan[i]} pris {prisvaran[i]} produktnummer {produktnummer[i]}");
                Console.ReadLine();
                Console.ReadKey();
            }

            

            


            Console.ReadLine();
        }
    }
}

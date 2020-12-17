using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    class Security
    {
        private string psWord;

        //Metoden för att kolla om lösenordet är giltigt eller ej.
        public static bool SecurityCheck(string psWord)
        {
            Console.Title = "Basgrupp3 inloggning";

            for (int i = 1; i < 4; i++)
            {
                Console.WriteLine("\nVälkommen till basgrupp3:s register");
                Console.Write("Var god och mata in lösenord: ");
                string userInput = Console.ReadLine();

                if (userInput == psWord)
                {
                    Console.Clear();
                    return true;
                    //Menu();
                    //break;
                }
                else
                {
                    Console.Beep();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nOgiltigt lösenord, var god försöka igen!");
                    Console.WriteLine($"Du har {3 - i} försök kvar");
                }
            }
            return false;
        }

        public string PsWord { get => psWord; set => psWord = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2.ProgramLogic
{
    class Security
    {
        private string password;

        //Metoden för att kolla om lösenordet är giltigt eller ej.
        public static bool SecurityCheck(string password, BaseGroup basegroup)
        {
            Console.Title = $"{basegroup} inloggning";
            //En for-loop för att hålla koll på hur många försök användaren har haft
            for (int i = 1; i < 4; i++)
            {
                Console.WriteLine($"\n Välkommen till {basegroup}:s register");
                Console.Write(" Var god och mata in lösenord: ");
                string userInput = Console.ReadLine();

                if (userInput == password)
                {
                    Console.Clear();
                    return true;
                }
                else
                {
                    Console.Beep(311, 700);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n Ogiltigt lösenord, var god försöka igen!");
                    Console.WriteLine($"Du har {3 - i} försök kvar");
                }
            }
            return false;
        }

        public string Password { get => password; set => password = value; }
    }
}

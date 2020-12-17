using System;
using System.Collections.Generic;

namespace Assignment2
{
    class Program
    {
        static List<BaseGroupMember> listOfMembers = new List<BaseGroupMember>();

        static void Main(string[] args)
        {
            SetUp();

            //SecurityCheck();


        }

        public static void SecurityCheck()
        {
            //int chance = 1;
            string password = "coffeencode";


            for (int i = 1; i < 4; i++)
            {
                Console.WriteLine("\nVälkommen till basgrupp3:s register");
                Console.Write("Var god och mata in lösenord: ");
                string userInput = Console.ReadLine();

                if (userInput != password)
                {
                    Console.Beep();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nOgiltigt lösenord, var god försöka igen!");
                    //int chanceLeft = 3 - chance;
                    Console.WriteLine($"Du har {3 - i} försök kvar");
                    //chance++;
                }
                else if (userInput == password)
                {
                    Menu();
                }


            }
            //while (chance < 4);

        }

        static void Menu()
        {
            int choice = 0;
            bool keepGoing = true;

            do
            {

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * ");
                Console.WriteLine("*              Basgrupp3 aka coffee'n'code                   *");
                Console.WriteLine("*   Du har följande val:                                     *");
                Console.WriteLine("*   1. Lista ut alla medlemar i gruppen                      *");
                Console.WriteLine("*   2. Få ut mer dateljerade informationer om enskild medlem *");
                Console.WriteLine("*   3. Ta bort en medlem                                     *");
                Console.WriteLine("*   4. Avsluta                                               *");
                Console.WriteLine(" * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        foreach (BaseGroupMember member in listOfMembers)
                        {
                            Console.Write(member.Age);
                        }
                        break;
                    case 2:

                        break;
                    case 3:
                        Console.WriteLine("Välj en medlem som du vill ta bort från registern.");

                        break;
                    case 4:
                        Console.WriteLine("Tack för besöket, adjö!");
                        keepGoing = false;
                        break;

                }
            }
            while (keepGoing);
        }

        static void RegBaseGroupMembers(BaseGroup b)
        {

            listOfMembers.Add(new BaseGroupMember("Mikael Alexander",
                                                  "Larsson",
                                                  "Vänersborg",
                                                  "36",
                                                  "Villa",
                                                  "Fru, 2 döttrar och en tredje på väg",
                                                  "2 kaniner",
                                                  "Restauranglärare",
                                                  "Träning och hälsa, surdegsbröd",
                                                  "Bönchiligryta i tortillabröd",
                                                  "Elektroniskt, allt mellan amibent och techno",
                                                  "Största driv till programmering: Har alltid tyckt det är intressant hur system är uppbyggda och hur de skapas, så nu vill jag kunna göra det själv"));

            listOfMembers.Add(new BaseGroupMember("Karin Madeleine",
                                                  "Karlsson",
                                                  "Stockholm",
                                                  "35",
                                                  "Hyr en villa",
                                                  "Sambo och en dotter",
                                                  "3 katter",
                                                  "Har varit ekonomiassistent, testare och senast föräldraledig",
                                                  "Bakning och spela Stardew Valley",
                                                  "Någon form form av biff, sötpotatis pommes och bearnésås",
                                                  "Just nu, allt som inte är barnvisor",
                                                  "Har alltid tyckt det är intressant hur system är uppbyggda och hur de skapas, så nu vill jag kunna göra det själv"));

            listOfMembers.Add(new BaseGroupMember("Sammy On Tat",
                                                  "Wong",
                                                  "Åmål",
                                                  "54",
                                                  "Villa",
                                                  "Fru och en son",
                                                  "3 katter och en hund",
                                                  "Personlig assistent",
                                                  "Fotografering, matlagning",
                                                  "Asiatisk, italiensk, svensk husmanskost",
                                                  "Soul, RnB, House",
                                                  "Att kunna skapa någonting själv, problemlösning och tillfredsställelse när man har löst ett problem."));

            listOfMembers.Add(new BaseGroupMember("David Josef",
                                                  "Frödin",
                                                  "Sundbyberg",
                                                  "25",
                                                  "Lägenhet",
                                                  "Det vanliga",
                                                  "Inga",
                                                  "Verksamhetschef på en BaseGroupMemberförening",
                                                  "Leta efter universums hemligheter, målning, lära sig språk",
                                                  "Bortsch",
                                                  "Allt! Inne i rockperiod som varvas med rysk folkmusik",
                                                  "Det är ballt och jag får kombinera kreativitet, problemlösning och människoperspektiv i en trevlig mix."));

            listOfMembers.Add(new BaseGroupMember("Rauf",
                                                  "Karimli",
                                                  "Göteborg",
                                                  "36",
                                                  "Villa",
                                                  "Fru, en son och en dotter",
                                                  "Inga",
                                                  "Projektledare",
                                                  "Spela piano, laga mat",
                                                  "Grillat kött",
                                                  "Gott och blandat",
                                                  "De gränslösa möjligheterna att utveckla och utvecklas"));

            listOfMembers.Add(new BaseGroupMember("Erik",
                                                  "Rindlert",
                                                  "Stockholm",
                                                  "31",
                                                  "Lägenhet",
                                                  "Ogift",
                                                  "Inga",
                                                  "IT-support",
                                                  "Litteratur, datotspel",
                                                  "Svensk-fransk fisksoppa",
                                                  "Schubert eller Darkthrone, beroende på dag",
                                                  "Bygga, bygga, bygga"));

            listOfMembers.Add(new BaseGroupMember("Daniel Jacob",
                                                  "Arlbring",
                                                  "Alingsås",
                                                  "24",
                                                  "Hyr en lägenhet",
                                                  "Sambo",
                                                  "Inga",
                                                  "Väktare",
                                                  "Motorsport/datorspel",
                                                  "Italienskt",
                                                  "House",
                                                  "Problemlösning"));

            listOfMembers.Add(new BaseGroupMember("Svante",
                                                  "Joelsson",
                                                  "Strömstad",
                                                  "36",
                                                  "Lägenhet",
                                                  "Sambo och en son",
                                                  "Hund",
                                                  "Fritidspedagog/Förskolelärare",
                                                  "Illustrera/Animera",
                                                  "Pasta al fungi",
                                                  "Gubbrock och allt som är bra",
                                                  "Kul combo av problemlösning och kreativitet, och att en dag landa ett jobb med mer frihet"));

            listOfMembers.Add(new BaseGroupMember("Sarah",
                                                  "Winroth",
                                                  "Vara",
                                                  "31",
                                                  "Lägenhet",
                                                  "Gift",
                                                  "Inga",
                                                  "Reseledare",
                                                  "Motionerar gärna",
                                                  "Älskar mat i alla former",
                                                  "Lyssnar på det mesta",
                                                  "Själva problemlösningen och tillfredsställelsen efteråt!"));

            listOfMembers.Add(new BaseGroupMember("Farzane",
                                                  "Zafarzade",
                                                  "Karlstad",
                                                  "32",
                                                  "Lägenhet",
                                                  "Min man och inget barn",
                                                  "Inga",
                                                  "IT-Support",
                                                  "Träning och bakning",
                                                  "Alla typer av pastarätter",
                                                  "Lugna och klassisk musik",
                                                  "Problemlösning, inom att lösa problem man lär sig att bli mer tålmodig och kreativ."));


            for (int i = 0; i < listOfMembers.Count; i++)
            {
                Console.WriteLine(string.Join(',', listOfMembers[i].FirstName));
            }



        }

        static void SetUp()
        {
            BaseGroup basGrupp3 = new BaseGroup("coffencode", 10);
            basGrupp3.Password = basGrupp3.Name;
            RegBaseGroupMembers(basGrupp3);

            SecurityCheck();


        }

    }

}

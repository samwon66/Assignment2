using Assignment2.Apprentice;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2.ProgramLogic
{
    class Run
    {
        private static List<BGMember> listOfMembers = new List<BGMember>();

        public static void GoAhead()
        {
            SetUp();
        }

        private static void Menu()
        {
            int choice = 0;
            bool keepGoing = true;

            while (keepGoing)
            {
                Console.Title = "Coffee'N'Code medlemsregister";
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n  * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * ");
                Console.WriteLine("*            Välkommen till Basgrupp3 aka coffee'n'code          *");
                Console.WriteLine("*   Du har följande val:                                         *");
                Console.WriteLine("*   1. Lista ut alla medlemmar i gruppen                         *");
                Console.WriteLine("*   2. Få ut mer detaljerade informationer om enskilda medlemen  *");
                Console.WriteLine("*   3. Ta bort en medlem                                         *");
                Console.WriteLine("*   4. Avsluta                                                   *");
                Console.WriteLine(" * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *  ");

                choice = Convert.ToInt32(Console.ReadLine());
                int nr;
                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("");
                        NameToArray(listOfMembers);
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("");
                        ShowAllMembers(listOfMembers);
                        Console.WriteLine("\n Välj en medlem som du vill titta närmare på.");
                        nr = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(listOfMembers[nr - 1].Describe());
                        break;
                    case 3:
                        bool loop = true;
                        Console.Clear();
                        do
                        {
                            Console.WriteLine("");
                            ShowAllMembers(listOfMembers);
                            Console.WriteLine("\n Välj en medlem som du vill ta bort från registern.");
                            nr = Convert.ToInt32(Console.ReadLine());
                            try
                            {
                                Console.WriteLine($" Du vill ta bort {listOfMembers[nr - 1].CallName}? (j/n) ");
                                char answer = Convert.ToChar(Console.ReadLine());
                                if (answer == 'j')
                                {
                                    Console.WriteLine($" {listOfMembers[nr - 1].CallName} är borttagen");
                                    listOfMembers.Remove(listOfMembers[nr - 1]);
                                    loop = false;
                                }
                                else
                                {
                                    Console.WriteLine(" Återgå till huvudmenyn.\n");
                                    loop = false;
                                }
                            }
                            catch
                            {
                                Console.WriteLine(" Du har angett ett ogiltigt svar!");
                            }
                        }
                        while (loop);
                        break;
                    case 4:
                        Console.WriteLine("");
                        Console.WriteLine(" Tack för besöket, adjö!");
                        keepGoing = false;
                        break;
                    default:
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(" Du har angett ett ogiltigt nummer! Var god försöka igen!\n");
                        break;
                }
            }

        }

        private static void NameToArray(List<BGMember> l)
        {
            List<BGMember> nameList = new List<BGMember>();
            foreach (BGMember m in l)
            {
                nameList.Add(m);
            }
            Console.Write(string.Join(", ", nameList));
            Console.WriteLine("\n\n");
        }

        private static void ShowAllMembers(List<BGMember> l)
        {
            int counter = 1;
            foreach (BGMember m in l)
            {
                Console.WriteLine($" {counter}. {m.CallName} ");
                counter++;
            }
            Console.WriteLine($" Vi har {l.Count} medlemmar i gruppen.");
        }

        private static void SetUp()
        {
            BaseGroup basGrupp3 = new BaseGroup("coffeencode");
            basGrupp3.ListOfMembers = new List<BGMember>();
            basGrupp3.AmountOfMembers = basGrupp3.ListOfMembers.Count;
            basGrupp3.Password = basGrupp3.Name;//Satt gruppens namn som lösenord.
            RegBaseGroupMembers(basGrupp3, basGrupp3.ListOfMembers);
            bool granted = Security.SecurityCheck(basGrupp3.Password, basGrupp3);
            if (granted)
            {
                Menu();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Clear();
                Console.WriteLine("\n Tyvärr, member only!\n MEN, vi har extra erbjudande just nu! \n Bli medlem för bara 199:-/mån och låt oss råna dig.");
            }
        }

        //Initiera alla data i gruppen och spara i gruppens lista.
        static void RegBaseGroupMembers(BaseGroup b, List<BGMember> memberList)
        {
            memberList = listOfMembers;
            memberList.Add(new BGMember("Mikael", "Mikael Alexander", "Larsson", "Vänersborg", "36", "Villa", "Fru, 2 döttrar och en tredje på väg", "2 kaniner", "Restauranglärare",
                                        "Träning och hälsa, surdegsbröd", "Bönchiligryta i tortillabröd", "Elektroniskt, allt mellan amibent och techno",
                                        "Största driv till programmering: Har alltid tyckt det är intressant hur system är uppbyggda och hur dskapas, så nu vill jag kunna göra det själv"));

            memberList.Add(new BGMember("Madeleine", "Karin Madeleine", "Karlsson", "Stockholm", "35", "Hyr en villa", "Sambo och en dotter", "3 katter",
                                        "Har varit ekonomiassistent, testare och senast föräldraledig", "Bakning och spela Stardew Valley", "Någon form form av biff, sötpotatis pommes och bearnésås",
                                        "Just nu, allt som inte är barnvisor", "Har alltid tyckt det är intressant hur system är uppbyggda och hur de skapas, så nu vill jag kunna göra det själv"));

            memberList.Add(new BGMember("Sammy", "Sammy On Tat", "Wong", "Åmål", "54", "Villa", "Fru och en son", "3 katter och en hund", "Personlig assistent", "Fotografering, matlagning",
                                        "Asiatisk, italiensk, svensk husmanskost", "Soul, RnB, House", "Att kunna skapa någonting själv, problemlösning och tillfredsställelse när man har löst ett problem."));

            memberList.Add(new BGMember("David", "David Josef", "Frödin", "Sundbyberg", "25", "Lägenhet", "Det vanliga", "Inga", "Verksamhetschef på en BaseGroupMemberförening",
                                        "Leta efter universums hemligheter, målning, lära sig språk", "Bortsch", "Allt! Inne i rockperiod som varvas med rysk folkmusik",
                                        "Det är ballt och jag får kombinera kreativitet, problemlösning och människoperspektiv i en trevlig mix."));

            memberList.Add(new BGMember("Rauf", "Rauf", "Karimli", "Göteborg", "36", "Villa", "Fru, en son och en dotter", "Inga", "Projektledare", "Spela piano, laga mat", "Grillat kött", "Gott och blandat",
                                        "De gränslösa möjligheterna att utveckla och utvecklas"));

            memberList.Add(new BGMember("Erik", "Erik", "Rindlert", "Stockholm", "31", "Lägenhet", "Ogift", "Inga", "IT-support", "Litteratur, datotspel", "Svensk-fransk fisksoppa",
                                        "Schubert eller Darkthrone, beroende på dag", "Bygga, bygga, bygga"));

            memberList.Add(new BGMember("Daniel", "Daniel Jacob", "Arlbring", "Alingsås", "24", "Hyr en lägenhet", "Sambo", "Inga", "Väktare", "Motorsport/datorspel", "Italienskt", "House", "Problemlösning"));

            memberList.Add(new BGMember("Svante", "Svante", "Joelsson", "Strömstad", "36", "Lägenhet", "Sambo och en son", "Hund", "Fritidspedagog/Förskolelärare", "Illustrera/Animera", "Pasta al fungi", 
                                        "Gubbrock och allt som är bra", "Kul combo av problemlösning och kreativitet, och att en dag landa ett jobb med mer frihet"));

            memberList.Add(new BGMember("Sarah", "Sarah", "Winroth", "Vara", "31", "Lägenhet", "Gift", "Inga", "Reseledare", "Motionerar gärna", "Älskar mat i alla former", "Lyssnar på det mesta", 
                                        "Själva problemlösningen och tillfredsställelsen efteråt!"));

            memberList.Add(new BGMember("Farzane", "Farzane", "Zafarzade", "Karlstad", "32", "Lägenhet", "Min man och inget barn", "Inga", "IT-Support", "Träning och bakning", "Alla typer av pastarätter", 
                                        "Lugna och klassisk musik", "Problemlösning, inom att lösa problem man lär sig att bli mer tålmodig och kreativ."));
        }


    }
}

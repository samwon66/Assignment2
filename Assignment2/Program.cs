﻿using System;
using System.Collections.Generic;

namespace Assignment2
{
    class Program
    {
        static List<BaseGroupMember> listOfMembers = new List<BaseGroupMember>();

        static void Main(string[] args)
        {
            SetUp();

            Console.WriteLine("Välkommen till basgrupp3:s register \nDu har följande val: \n1. Lista ut alla medlemar i gruppen ");
        }

        static void SetUp()
        {
            BaseGroup basGrupp3 = new BaseGroup("coffencode", 10);
            //Console.WriteLine(basGrupp3.Name);
            RegBaseGroupMembers();

        }

        static void RegBaseGroupMembers()
        {

            listOfMembers.Add(new BaseGroupMember("Mikael Alexander", "Larsson", "Vänersborg", "36", "Villa",
                                                  "Fru, 2 döttrar och en tredje på väg", "2 kaniner", "Restauranglärare", "Träning och hälsa, surdegsbröd",
                                                  "Bönchiligryta i tortillabröd", "Elektroniskt, allt mellan amibent och techno"));
            listOfMembers.Add(new BaseGroupMember("Karin Madeleine", "Karlsson", "Stockholm", "35", "Hyr en villa", "Sambo och en dotter", "3 katter",
                                                            "Har varit ekonomiassistent, testare och senast föräldraledig", "Bakning och spela Stardew Valley",
                                                            "Någon form form av biff, sötpotatis pommes och bearnésås", "Just nu, allt som inte är barnvisor"));
            listOfMembers.Add(new BaseGroupMember("Sammy On Tat", "Wong", "Åmål", "54", "Villa", "Fru och en son", "3 katter och en hund", "Personlig assistent",
                                                        "Fotografering, matlagning", "Asiatisk, italiensk, svensk husmanskost", "Soul, RnB, House"));
            listOfMembers.Add(new BaseGroupMember("David Josef", "Frödin", "Sundbyberg", "25", "Lägenhet", "Det vanliga", "Inga", "verksamhetschef på en BaseGroupMemberförening",
                                                        "Leta efter universums hemligheter, målning, lära sig språk", "Bortsch",
                                                        "Allt! Inne i rockperiod som varvas med rysk folkmusik"));
            listOfMembers.Add(new BaseGroupMember("Rauf", "Karimli", "Göteborg", "36", "Villa", "Fru, en son och en dotter", "Inga", "Projektledare",
                                                       "Spela piano, laga mat", "Grillat kött", "Gott och blandat"));
            listOfMembers.Add(new BaseGroupMember("Erik", "Rindlert", "Stockholm", "31", "Lägenhet", "Ogift", "Inga", "IT-support", "Litteratur, datotspel",
                                                       "Svensk-fransk fisksoppa", "Schubert eller Darkthrone, beroende på dag"));
            listOfMembers.Add(new BaseGroupMember("Daniel Jacob", "Arlbring", "Alingsås", "24", "Hyr en lägenhet", "Sambo", "Inga", "Väktare", "Motorsport/datorspel",
                                                         "Italienskt", "House"));
            listOfMembers.Add(new BaseGroupMember("Svante", "Joelsson", "Strömstad", "36", "Lägenhet", "Sambo och en son", "hund", "Fritidspedagog/Förskolelärare",
                                                         "Illustrera/Animera", "Pasta al fungi", "Gubbrock och allt som är bra"));
            listOfMembers.Add(new BaseGroupMember("Sarah", "Winroth", "Vara", "31", "Lägenhet", "Gift", "Inga", "Reseledare", "Motionerar gärna",
                                                        "Älskar mat i alla former", "Lyssnar på det mesta"));
            listOfMembers.Add(new BaseGroupMember("Farzane", "Zafarzade", "Karlstad", "32", "Lägenhet", "min man och inget barn", "Inga", "IT-Support",
                                                          "Träning och bakning", "Alla typer av pastarätter", "Lugna och klassisk musik"));

            
            foreach(BaseGroupMember member in listOfMembers)
            {
                Console.WriteLine(member.FirstName);
            }

        }


    }

}

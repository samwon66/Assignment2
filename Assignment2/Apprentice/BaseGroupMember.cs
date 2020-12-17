using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2.Apprentice
{
    class BaseGroupMember : Student
    {
        private string callName;
        private string motivProg;

        public BaseGroupMember() { }

        public BaseGroupMember(string callName, string firstName, string lastName, string city, string age, string accomodation, string family, string pet, string prevProfession, string hobby, string favFood, string favMusic, string motivProg)
        {
            this.CallName = callName;
            this.MotivProg = motivProg;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.City = city;
            this.Age = age;
            this.Accommodation = accomodation;
            this.Family = family;
            this.Pet = pet;
            this.PrevProfession = prevProfession;
            this.Hobby = hobby;
            this.FavFood = favFood;
            this.FavMusic = favMusic;
        }


        public string Describe()
        {
            return $"Förnamn: {FirstName}\n" +
                   $"Efternamn: {LastName}\n" +
                   $"Stad: {City}\n" +
                   $"Ålder: {Age}\n" +
                   $"Boende: {Accommodation}\n" +
                   $"Familj: {Family}\n" +
                   $"Husdjur {Pet}\n" +
                   $"Senast yrke: {PrevProfession}\n" +
                   $"Hobby: {Hobby}\n" +
                   $"Favorit mat: {FavFood}\n" +
                   $"Favorit musik: {FavMusic}\n" +
                   $"Driv till programmering: {MotivProg}";

        }

        
       

        public override string ToString()
        {
            return $"{CallName}";
        }

        public string CallName { get => callName; set => callName = value; }
        public string MotivProg { get => motivProg; set => motivProg = value; }

        
    }
}

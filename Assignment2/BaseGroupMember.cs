using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    class BaseGroupMember
    {
        private string firstName;
        private string lastName;
        private string city;
        private string age;
        private string accommodation;
        private string family;
        private string pet;
        private string prevProfession;
        private string hobby;
        private string favFood;
        private string favMusic;
        private string motivProg;

        public BaseGroupMember() { }

        public BaseGroupMember(string firstName, string lastName, string city, string age, string accommodation, string family, string pet, string prevProfession, string hobby, string favFood, string favMusic, string motivProg)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.city = city;
            this.age = age;
            this.accommodation = accommodation;
            this.family = family;
            this.pet = pet;
            this.prevProfession = prevProfession;
            this.hobby = hobby;
            this.favFood = favFood;
            this.favMusic = favMusic;
            this.motivProg = motivProg;
        }

        public List<string> MemNameList()
        {
            List<string> membNameList = new List<string>();
            membNameList.Add(firstName);
            return membNameList;

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
            return $"{firstName} {lastName}";
        }


        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string City { get => city; set => city = value; }
        public string Age { get => age; set => age = value; }
        public string Accommodation { get => accommodation; set => accommodation = value; }
        public string Family { get => family; set => family = value; }
        public string Pet { get => pet; set => pet = value; }
        public string PrevProfession { get => prevProfession; set => prevProfession = value; }
        public string Hobby { get => hobby; set => hobby = value; }
        public string FavFood { get => favFood; set => favFood = value; }
        public string FavMusic { get => favMusic; set => favMusic = value; }
        public string MotivProg { get => motivProg; set => motivProg = value; }
    }
}

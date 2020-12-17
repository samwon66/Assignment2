using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2.Apprentice
{
    class Student
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
    }
}

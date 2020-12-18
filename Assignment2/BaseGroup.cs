using Assignment2.Apprentice;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    class BaseGroup
    {
        private string name;
        private int amountOfMembers;
        private List<BGMember> listOfMembers;
        private string password;

        public BaseGroup() { }

        public BaseGroup(string name)
        {
            this.name = name;
            //this.amountOfMembers = amountOfMembers;
            //this.listOfMembers = listOfMembers;
        }

        //public BaseGroup(string name, int amountOfMembers)
        //{
        //    this.name = name;
        //    this.amountOfMembers = amountOfMembers;
        //}


        public string Name { get => name; set => name = value; }
        public int AmountOfMembers { get => amountOfMembers; set => amountOfMembers = value; }
        public string Password { get => password; set => password = value; }
        public List<BGMember> ListOfMembers { get => listOfMembers; set => listOfMembers = value; }

        public override string ToString()
        {
            return $"{name}";
        }

    }
}

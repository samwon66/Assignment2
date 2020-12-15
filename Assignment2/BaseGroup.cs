﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    class BaseGroup
    {
        private string name;
        private int amountOfMembers;

        public BaseGroup() { }
        
        public BaseGroup(string name, int amountOfMembers)
        {
            this.name = name;
            this.amountOfMembers = amountOfMembers;
        }

        public string Name { get => name; set => name = value; }
        public int AmountOfMembers { get => amountOfMembers; set => amountOfMembers = value; }

        public override string ToString()
        {
            return $"{name} ";
        }
    }
}

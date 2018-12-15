﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    public class Animal
    {
        public string Name { get; set; }
        

        public Animal(string name, Gender gender)
        {
            this.Name = name;
            this.Gender = gender;
        }

        public Gender Gender { get; set; }
    }

    public enum Gender
    {
        Male,
        Female
    }
}

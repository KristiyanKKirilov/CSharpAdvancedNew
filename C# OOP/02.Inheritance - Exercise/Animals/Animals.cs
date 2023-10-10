﻿using System;
using System.Text;

namespace Animals
{
    public abstract class Animal
    {
        private string name;
        private int age;
        private string gender;
        public Animal(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid input!");
                }
                else
                {
                    age = value;
                }                
            }

        }
        public string Gender
        {
            get
            {
                return gender;
            }
            set
            {
                gender = value;
            }
        }
        public virtual string Sound { get; set; }
        public virtual string ProduceSound()
        {
            return Sound;
        }
        public override string ToString()
        {
            return $"{Name} {Age} {Gender}";
        }
    }


}

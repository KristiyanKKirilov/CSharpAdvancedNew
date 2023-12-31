﻿namespace Animals
{
    public class Dog : Animal
    {
        private const string DefaultSound = "Woof!";
        public Dog(string name, int age, string gender)
            : base(name, age, gender)
        {
        }
        public override string Sound => DefaultSound;
    }
}

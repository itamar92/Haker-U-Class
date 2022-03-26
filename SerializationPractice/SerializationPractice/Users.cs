using System;
using System.Text.Json;
using System.Collections.Generic;

namespace SerializationPractice
{
    public class Users
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Users() { }

        public Users(string name, int age)
        {
            Age = age;
            Name = name;
        }

        public override string ToString()
        {
            return $"{Name}, {Age} ";
        }


    }
}


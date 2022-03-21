using System;
using System.Text.Json;
using System.Collections.Generic;

namespace SerializationPractice
{
	public class Users
	{
        public string Name { get; set; }
        public int  Age { get; set; }

		public Users() { }

        public Users(string name, int age)
		{
			Age = age;
			Name = name;
		}

		public string Payment()
        {
			if (Age < 25)
            {
                return "need to pay 9,000 ";
            }
			else
            {
				return "need to pay 10,000 ";
			}
        }

		public override string ToString()
        {
            return $"{Name}, {Age} ";
        }

		
	}
}


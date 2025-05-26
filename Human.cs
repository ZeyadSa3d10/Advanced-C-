using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBot
{
    internal  class Human
    {
        private string Name;
        private int Age;
        private int Id;

        public void SetName(string Name)
        {
            this.Name = Name;
        }
        public string GetName()
        {
            return Name;
        }
        public void SetId(int Id)
        {
            this.Id = Id;
        }
        public void SetAge(int Age)
        {
            this.Age = Age;
        }
        public void HumanDetails()
        {
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Age  : {Age}");
            Console.WriteLine($"Id   : {Id}");
        }

    }
}

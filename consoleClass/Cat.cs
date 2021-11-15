using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleClass
{
    internal class Cat
    {
        public string name;
        public string breed;
        public int age;
        public bool isWhite;

        public Cat(string name, string breed, int age, bool isWhite)
        {
            this.name = name;
            this.breed = breed;
            this.age = age;
            this.isWhite = isWhite;
        }

        public void PrintDetails()

        {
            Console.WriteLine(this.GetDatails());
        }

        string GetDatails()
        {
            return ($"name:{this.name},breed:{this.breed},age:{this.age},is white:{this.isWhite}");
        }
    }

}

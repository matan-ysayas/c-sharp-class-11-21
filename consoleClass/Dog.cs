using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleClass
{
    class Dog
    {
        public string name;
        public string breed;
        public int age;
        public bool isVaccienedd;

        public Dog(string name, string breed, int age, bool isVaccienedd)
        {
            this.name = name;
            this.breed = breed;
            this.age = age;
            this.isVaccienedd = isVaccienedd;
        }

        public string GetDog()
        {
            return ($"name:{this.name}, breed:{this.breed}, age:{this.age}, is vaccienedd: {this.isVaccienedd}");
        }
    }
}


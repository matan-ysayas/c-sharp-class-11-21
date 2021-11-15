using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleClass
{
     class Student
    {
        public string name;
        public int age;
        public int grage;

        public Student(string name,int age, int grage)
        {
            this.name = name;
            this.age = age;
            this.grage = grage;

        }
         string GetDetiles()
        {
            return ($" name:{this.name} age:{this.age} grage:{this.grage}");
        }

        public void PrintDetils()
        {
            Console.WriteLine( this.GetDetiles());
        }

        public void Undr8()
        {
            if (this.age < 8)
            {
                Console.WriteLine("ysodi");
            }
            else { Console.WriteLine("high scool"); }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleClass
{
    internal class Professor
    {
      public  string firstName;
       public string lastName;
       public int bornYear;
      public  bool isCar;

        public Professor(string firstName,string lastName,  int bornYear,  bool isCar)
        {
            this.firstName = firstName; 
            this.lastName = lastName;
            this.bornYear = bornYear;
            this.isCar = isCar;

        }
        string GetDetiles()
        {
            return ($" first name:{this.firstName} last name:{this.lastName}born year:{this.bornYear} is car:{this.isCar}");
        }

        public void PrintDetils()
        {
            Console.WriteLine(this.GetDetiles());
        }
         public void printIfCarAndOld()
        {
            if (this.isCar & this.bornYear > 1995)
            {
                Console.WriteLine($"{this.firstName} {this.lastName}");
            }
        }

    }
}

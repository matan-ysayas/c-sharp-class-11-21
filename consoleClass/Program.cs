using System;
namespace consoleClass
{
    class Progrem
    {
        static void Main(string[] args)
        {

            //Dog myDog = new Dog("bob", "dfdf", 25, true);
            //Console.WriteLine($"name:{myDog.name}, breed:{myDog.breed}, age:{myDog.age}, is vaccienedd: {myDog.isVaccienedd}");

            //Console.WriteLine(myDog.GetDog());

            //Cat myCat = new Cat("sdsd", "sdsd", 25, true);

            //myCat.PrintDetails();



            //Student myStudent = new Student("matan", 25, 26);

            //myStudent.PrintDetils();

            //myStudent.Undr8();


            Professor myprofessor = new Professor("matan", "ysayas", 1996, true);

            myprofessor.PrintDetils();
            myprofessor.printIfCarAndOld(); 
        }

    }
}
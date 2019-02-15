using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L1T2
{
   
    class Student
    {
        public string name;
        public string id;
        public string yearofstudy;

        public Student(string name, string id, string yearofstudy) // constructor with 3 parameters
        {
            this.name = name; // this - clue word that helps differ variables (that are from a class or from the "outside")
            this.id = id;    // in order to escape confusin situation between two parameters
            this.yearofstudy = yearofstudy;
        }

        public Student()
        {
            string[] reading = Console.ReadLine().Split(); // reading and spliting input
            while (reading.Length != 3) // reading until there are 3 inputs
            {
                reading = Console.ReadLine().Split();
            } // reading = {Tim, 18BD, 2019}
            this.name = reading[0];  // Tim
            this.id = reading[1]; // 18BD
            this.yearofstudy = reading[2]; // 2019
        }

        public void access() // method that returns information about student
        {
            Console.WriteLine(name + " " + id + " " + yearofstudy);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(); // initialize the information using the constructor
            Student student2 = new Student("Alex", "18BD010203", "2019"); // 3 parameters
            student.access(); // method returns information
            student2.access(); 

            Console.ReadKey();
        }
    }

}
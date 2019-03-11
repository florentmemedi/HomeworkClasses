using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework.Student;

namespace Homework.Student
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] Students = new Student[5];
            Students[0] = new Student("Florent", "SEDC", "G2");
            Students[1] = new Student("Aleksandar", "SEDC", "G3");
            Students[2] = new Student("Zoran", "SEDC", "G4");
            Students[3] = new Student("Nikola", "SEDC", "G5");
            Students[4] = new Student("Goran", "SEDC", "G6");

            Console.Write("Please enter the name of a student:");
            var input = Console.ReadLine();

            var search = false;
            foreach (var Student in Students)

            {
                if (input == Student.Name)
                {
                    search = true;
                    if (search)
                    {
                        Console.WriteLine($"The student that you searched is: \n Student Name: {Student.Name} " +
                            $"\n Student Academy: {Student.Academy} " +
                            $"\n Student Group: {Student.Group}");
                    }
                    break;
                }
            }
            if (!search)
            {
                Console.WriteLine("Sorry, there is not a Student with that name. \n" +
                    "Please enter another name of a Student!");
            }

            Console.ReadLine();

        }
    }
}

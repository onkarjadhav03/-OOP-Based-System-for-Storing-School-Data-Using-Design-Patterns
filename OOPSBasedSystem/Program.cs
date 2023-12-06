using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSBasedSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            School school = new School();

            // Add sample student data
            school.AddStudent(new Student("Rohut", "7", "A"));
            school.AddStudent(new Student("Virat", "7", "A"));
            school.AddStudent(new Student("Shami", "7", "A"));
            school.AddStudent(new Student("Aditit", "7", "A"));
            school.AddStudent(new Student("Rahul", "7", "A"));
            school.AddStudent(new Student("Kishan", "8", "B"));
            school.AddStudent(new Student("Manish", "8", "B"));
            school.AddStudent(new Student("Vishswas", "8", "B"));
            school.AddStudent(new Student("Taniya", "9", "C"));
            school.AddStudent(new Student("Siraj", "9", "C"));

            // Add sample teacher data
            school.AddTeacher(new Teacher("Mr. Rao", "7", "A"));
            school.AddTeacher(new Teacher("Ms. Sawant", "7", "B"));
            school.AddTeacher(new Teacher("Mr. Kulkarni", "7", "C"));

            // Add sample subject data
            school.AddSubject(new Subject("Physics", "PHY101", school.teachers[0]));
            school.AddSubject(new Subject("Maths", "MATH101", school.teachers[0]));
            school.AddSubject(new Subject("Biology", "BIO101", school.teachers[1]));
            school.AddSubject(new Subject("Botny", "BOT101", school.teachers[1]));
            school.AddSubject(new Subject("English", "ENGL101", school.teachers[2]));
            school.AddSubject(new Subject("Chemistry", "CHEM101", school.teachers[2]));


            // Display students in class 
            Console.WriteLine("Students in 7th Class:");
            foreach (Student student in school.GetStudentsByClass("7"))
            {
                Console.WriteLine(student.Name);
            }
            Console.WriteLine();

            Console.WriteLine("Students in 8th Class:");
            foreach (Student student in school.GetStudentsByClass("8"))
            {
                Console.WriteLine(student.Name);
            }
            Console.WriteLine();

            Console.WriteLine("Students in 9th Class:");
            foreach (Student student in school.GetStudentsByClass("9"))
            {
                Console.WriteLine(student.Name);
            }

            // Display subjects taught by Teachers
            Console.WriteLine("\nSubjects taught by Mr. Rao:");
            foreach (Subject subject in school.GetSubjectsTaughtByTeacher("Mr. Rao"))
            {
                Console.WriteLine(subject.Name);
            }

            Console.WriteLine("\nSubjects taught by Ms. Sawant:");
            foreach (Subject subject in school.GetSubjectsTaughtByTeacher("Ms. Sawant"))
            {
                Console.WriteLine(subject.Name);
            }
            Console.WriteLine("\nSubjects taught by Mr. Kulkarni:");
            foreach (Subject subject in school.GetSubjectsTaughtByTeacher("Mr. Kulkarni"))
            {
                Console.WriteLine(subject.Name);
            }

            Console.ReadKey();
        }
    }
}

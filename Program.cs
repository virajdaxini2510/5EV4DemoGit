using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5EV4DemoGit
{
    /// <summary>
    /// Class student to demonstrate the concept of classes and objects in C#.
    /// </summary>
    class Student
    {
        /// <summary>
        /// Public fields to store student details: Roll Number, Name, and Course.
        /// </summary>
        public int RollNo;
        public string Name;
        public string Course;

        /// <summary>
        /// Gets student data from user input and assigns it to the respective fields.
        /// </summary>
        public void GetStudentData()
        {
            Console.WriteLine("Enter Roll Number : ");
            RollNo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Student Name : ");
            Name = Console.ReadLine();

            Console.Write("Enter Course : ");
            Course = Console.ReadLine();
        }

        /// <summary>
        /// Displays the student data stored in the fields to the console.
        /// </summary>
        public void DisplayStudentData()
        {
            Console.WriteLine("\n===== Student Details =====");
            Console.WriteLine("Roll Number : " + RollNo);
            Console.WriteLine("Student Name: " + Name);
            Console.WriteLine("Course      : " + Course);
        }

        /// <summary>
        /// Main method to create a Student object, get student data, and display it.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Student s = new Student();

            s.GetStudentData();
            s.DisplayStudentData();

            Console.ReadKey();
        }
    }
}

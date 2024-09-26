using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiKiemTra1
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
        }
    }

    class Student : Person
    {
        public string StudentID { get; set; }

        public override void ShowInfo()
        {
            base.ShowInfo(); 
            Console.WriteLine($"Student ID: {StudentID}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student
            {
                Name = "John Doe",
                Age = 20,
                StudentID = "S12345"
            };

            student.ShowInfo();
        }
    }
}

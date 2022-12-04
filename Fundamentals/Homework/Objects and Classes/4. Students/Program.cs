using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumofCom = int.Parse(Console.ReadLine());
            List<Student> list = new List<Student>();
            for (int i = 0; i < NumofCom; i++)
            {
                List<string> read = Console.ReadLine().Split(" ").ToList();
                Student student = new Student(read[0], read[1], float.Parse(read[2]));
                list.Add(student);
            }
            
            list=list.OrderByDescending(x => x.Grade).ToList();

            foreach (var item in list)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
    public class Student
    {
        public Student(string fname, string lname, float grade)
        {
            Fname = fname;
            Lname = lname;
            Grade = grade;
        }

        public string Fname { get; set; }
        public string Lname { get; set; }
        public float Grade { get; set; }

        public override string ToString()
        {
            return $"{Fname} {Lname}: {Grade:F2}";
        }


    }
}

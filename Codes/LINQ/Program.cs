using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Print(dynamic students)
        {
            foreach (var s in students)
            {
                //s.Show();
                Console.WriteLine("Name " + s.Name);
                Console.WriteLine("Cgpa " + s.Cgpa);
            }
        }
        static void Main(string[] args)
        {
           List<Student> students = new List<Student>();
            Random rand = new Random();
            for(int i = 0; i < 1000; i++)
            {
                Student s = new Student();
                s.Id = i;
                s.Name = "Student " + i;
                s.Cgpa = rand.NextDouble()*(4.00-2.50)+2.50;
                students.Add(s);
            }

            /* //for SINGLE Condition
            var filteresStu = (from s in students
                              where s.Cgpa >3.75
                              select s).ToList();
            */


            //for MULTIPLE COndition
            dynamic filteresStu = (from s in students
                               where s.Cgpa > 3.75 &&
                               (s.Id >=1 && s.Id <=100 || s.Id >= 901 && s.Id<=1000)
                               && s.Name.Contains("1")
                               select new {s.Name,s.Cgpa}).ToList();
            Print(filteresStu);


            /*int[] arr = new int[] { 12, 23, 22, 14, 34, 65, 43, 27 };

            var filtered = (from i in arr 
                            where i > 20 
                            select i).ToList();
            */
        }
    }
}

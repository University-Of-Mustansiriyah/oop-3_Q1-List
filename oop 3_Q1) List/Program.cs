using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace oop_3_Q1__List
{
    class Student
    {
        public string id;
        public string name;
        public double mark;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> s = new List<Student>();
            Console.WriteLine("input 5-10 students");
            int x = int.Parse(Console.ReadLine());
            if (x >= 5 && x <= 10)
            {
                for (int i = 0; i < x; i++)
                {
                    Student st = new Student();
                    Console.WriteLine("enetr the id");
                    st.id = Console.ReadLine();
                    Console.WriteLine("enter the name");
                    st.name = Console.ReadLine();
                    Console.WriteLine("enter the mark");
                    st.mark = double.Parse(Console.ReadLine());
                    s.Add(st);
                }
            }
            for(int i=0;i<s.Count;i++)
            {
                if (s[i].mark >= 50)
                    Console.WriteLine(s[i].name);
            }
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8.method
{
    internal class Student
    {
        public static int Count  { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Id { get; set; }
        public Student (String Name,string Surname)
        {
            Name = Name;
            Surname = Surname;
            Count = Id;
            Count++;
        }
        public void GetInfo()
        {
            Console.WriteLine( $"{Id} {Name} { Surname }"); 
            
        }

    }
}

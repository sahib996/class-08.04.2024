using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ConsoleApp8.method
{
    internal class Group; Student
    {
        public static Group[] Groups = new Group[0];
        static int GroupCount {  get; set; }
        public string GroupName { get; set; }
        public int GroupId { get; set; }
        Student[] Students =new Student[0];


        public  void GetGroupInfo()
        {
            Console.WriteLine($"{ GroupId}{GroupName}");
            foreach (Student students in Students)
            {
                student.GetInfo();
            }
        }
        public void  GetStudent(int Id)
        {
            for( int i = 0; i<Students.Length; i++)
            {
                if(i == Id)
                {
                    Students[i].GetInfo();
                }
            }
        } 
          public void AddStudent(Student student)
              {
                  Array.Resize(ref Groups,Groups.Lenght +1)
            {
            Groups[Groups.Lenght - 1] = Group;
            }
              }
              public void Search(string a)
    {
        foreach(Student student in Students)
        {
            if(a==student.Name|| a==student.Surname)
            {
                Console.WriteLine(student.GetInfo);
            }

        }
    }
    public override string ToString()
    {
        return $"{GroupID} {groupName}";
        foreach (Student student in Students)
        {
            Console.WriteLine($"{student,Name} {student.Surname} {Student.Id}");
        }
    }
    }
}
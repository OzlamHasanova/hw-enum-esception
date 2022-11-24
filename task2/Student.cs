using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    public class Student
    {
        public static int Id;
        public static int id;
        public string Name;
        public string Surname;
        public string GroupNo;

        public Student(string name, string surname, string groupNo)
        {
            
            Name = name;
            Surname = surname;
            GroupNo = groupNo;
            id++;
            id = Id;

        }
        
        public string StudentInfo() => $"Id{Id}-Name{Name}-Surname{Surname}-GroupNo{GroupNo}";
    }
}

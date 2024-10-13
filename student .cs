using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace task_14._10
{
    internal class Student
    {
        public string Name;
        public string Surname;
        public string Group;
        public byte Point;
        public bool IsGraduated;

        public Student(string name, string surname, string group, byte point)
        {
            Name = name;
            Surname = surname;
            Group = group;
            Point = point;
            CheckGraduation();
        }

        public void GetInfo()
        {
            Console.WriteLine($"Name: {Name}, Surname: {Surname}, Group: {Group}, Point: {Point}, IsGraduated: {IsGraduated}");
        }
        public void CheckGraduation()
        {
            IsGraduated = Point >= 65; 

            if (IsGraduated)
            {
                Console.WriteLine("Mezun olub");
            }
            else
            {
                Console.WriteLine("Kesilib");
            }
        }



        public void GetDiplomDegree()
        {
            if (Point < 65)
            {
                Console.WriteLine("Yoxdur");
            }
            else if (Point <= 80)
            {
                Console.WriteLine("Adi");
            }
            else if (Point <= 90)
            {
                Console.WriteLine("Şeref");
            }
            else // Point > 90
            {
                Console.WriteLine("Yüksək şərəf");
            }
        }
    }
}


    

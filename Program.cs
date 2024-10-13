
using System;

namespace task_14._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            Student student = new Student("Kubra", "Ahmadova", "TT-02", 80);
            Student student2 = new Student("Fatima", "Karimli", "RM-120", 50);
            student.GetInfo();
            student.GetDiplomDegree(); 
            student.CheckGraduation();
            student2.GetInfo();
            student2.CheckGraduation();
            student2.GetDiplomDegree();

        }
    }
}

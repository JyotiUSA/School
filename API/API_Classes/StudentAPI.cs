using School.API.API_Interfaces;
using School.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.API.API_Classes
{
    class StudentAPI : IStudentAPI
    {
        public StudentAPI()
        {
            
        }
        public void Displaystudentdetails(StudentModel sm)
        {
            Console.WriteLine($"\nName:\t\t{sm.Name}\nStd.:\t\t{sm.Std}\nRoll no." +
                $":\t{sm.RollNo}\nBirth date:\t{sm.BirthDate.ToShortDateString()}");
        }

        //public void Examination(StudentModel sm)
        //{
        //    double totalMarks;
        //    double percentage;
        //    string result;

        //    IExaminationAPI exam = new ExaminationAPI();

        //    Console.Write($"\nNow enter your marks as instructed follow:-\n");

        //    for (int i = 0; i < 4; i++)
        //    {
        //        Console.Write($"Enter {exam.getSubjects()[i]} marks =\t");
        //        student.ObtainedMarks[i] = int.Parse(Console.ReadLine());
        //        if (student.ObtainedMarks[i] > 100)
        //        {
        //            Console.WriteLine("Marks cannot be greater than 100. Please enter the mark again.");
        //            i -= 1;
        //        }
        //    }
        //}

        //public double PercentageCalculation(ExaminationModel em)
        //{
        //    throw new NotImplementedException();
        //}
    }
}

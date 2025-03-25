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
    }
}

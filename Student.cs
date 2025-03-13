
using Csharp;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Student : ExaminationDepartment
    {
        private int rollNo;
        private string name;
        private int std;
        private DateTime birthDate;

        public DateTime BirthDate
        {
            get
            {
                return birthDate;
            }
            set
            {
                birthDate = value;
            }
        }

        public int Std
        {
            get
            {
                return std;
            }
            set
            {
                std = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public int RollNo
        {
            get
            {
                return rollNo;
            }
            set
            {
                rollNo = value;
            }
        }

        //Constructor
        public Student(string name, int std, int rollNo, DateTime birthDate)
        {
            RollNo = rollNo;
            Name = name;
            Std = std;
            BirthDate = birthDate;
        }

        //Display Students details
        public void DisplayStudentsDetails()
        {
            Console.WriteLine($"\nName:\t\t{Name}\nStd.:\t\t{Std}\nRoll no.:\t{RollNo}\nBirth date:\t{BirthDate.ToShortDateString()}");
        }

        //Display Examination Report
        public void Examination()
        {
            double totalMarks;
            double percentage;
            string result;

            ExaminationDepartment exame = new ExaminationDepartment();

            Console.Write($"\nNow enter your marks as instructed follow:-\n");

            for (int i = 0 ; i < 4; i++)
            {
                Console.Write($"Enter {Subject[i]} marks =\t");
                ObtainedMarks[i] = int.Parse(Console.ReadLine());
                if (ObtainedMarks[i] > 100)
                {
                    Console.WriteLine("Marks cannot be greater than 100. Please enter the mark again.");
                    i -= 1;
                }
            }

            Console.WriteLine("");
            for (int i = 0; i < 4; i++)
            {
                Console.Write($"{Subject[i]} = {ObtainedMarks[i]} /100 ;\t");
            }

            totalMarks = exame.Exame(ObtainedMarks[0] , ObtainedMarks[1] , ObtainedMarks[2] , ObtainedMarks[3]);

            Console.WriteLine("");
            Console.WriteLine($"\nTotal Marks :\t{totalMarks}");

            percentage = exame.PercentageCalculation();
            Console.WriteLine($"\nPercentage :\t{percentage}%");

            result = exame.ExameResultStatus();
            Console.WriteLine($"\n{this.Name}\t{result} in the examination");

        }

        #region Added functionality - used .dll flie and added into COM reference.
        //i.e., logic was written by another team in different project & we are using its functionality by calling yhe defined method
        public static void finalStatement()
        {
            GoodByeMessage goodByeMessage = new GoodByeMessage();
            goodByeMessage.PrintAtEnd();
            Console.WriteLine("-------------------------");
        }
        #endregion

        #region Method to create Json of 'object of this(Student) class'
        public string ConvertToJson()
        {
            string json = JsonConvert.SerializeObject(this);
            return json;
        }
        #endregion
    }
}

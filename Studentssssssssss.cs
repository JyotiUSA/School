
////using Csharp;
//using Newtonsoft.Json;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Globalization;
//using System.Linq;
//using System.Net;
//using System.Text;
//using System.Threading.Tasks;
//using System.Xml.Linq;

//namespace School
//{
//    interface IStudentApi
//    {
//        void Examination(Student s);
//        void Displaystudentdetails(Student s);
//    }

//    class Student
//    {
//        public static int countStudents = 1;
//        private DateTime birthDate;
//        private int std;
//        private string name;
//        private int rollNo;

//        public DateTime BirthDate
//        {
//            get
//            {
//                return birthDate;
//            }
//            set
//            {
//                birthDate = value;
//            }
//        }

//        public int Std
//        {
//            get
//            {
//                return std;
//            }
//            set
//            {
//                std = value;
//            }
//        }

//        public string Name
//        {
//            get
//            {
//                return name;
//            }
//            set
//            {
//                name = value;
//            }
//        }

//        public int RollNo
//        {
//            get
//            {
//                return rollNo;
//            }
//            set
//            {
//                rollNo = value;
//            }
//        }

//        private int[] obtainedMarks = new int[4];
//        public int[] ObtainedMarks
//        {
//            get { return obtainedMarks; }
//            set { obtainedMarks = value; }
//        }
//    }

//    class StudentApi : IStudentApi
//    {
//        public StudentApi()
//        {

//        }





//        //public Student(string name, int std, int rollNo, DateTime birthDate)
//        //{
//        //    RollNo = rollNo;
//        //    Name = name;
//        //    Std = std;
//        //    BirthDate = birthDate;
//        //}

//        //Display Students details



//        //Display Examination Report
//        public void Examination(Student student)
//        {
//            double totalMarks;
//            double percentage;
//            string result;

//            IExaminationDepartment exame = new ExaminationDepartment();
//            var test = exame.getSubjects()[0];

//            Console.Write($"\nNow enter your marks as instructed follow:-\n");

//            for (int i = 0; i < 4; i++)
//            {
//                Console.Write($"Enter {exame.getSubjects()[i]} marks =\t");
//                student.ObtainedMarks[i] = int.Parse(Console.ReadLine());
//                if (student.ObtainedMarks[i] > 100)
//                {
//                    Console.WriteLine("Marks cannot be greater than 100. Please enter the mark again.");
//                    i -= 1;
//                }
//            }

//            Console.WriteLine("");
//            for (int i = 0; i < 4; i++)
//            {
//                Console.Write($"{exame.getSubjects()[i]} = {student.ObtainedMarks[i]} /100 ;\t");
//            }

//            totalMarks = exame.Exame(student.ObtainedMarks[0], student.ObtainedMarks[1], student.ObtainedMarks[2], student.ObtainedMarks[3]);

//            Console.WriteLine("");
//            Console.WriteLine($"\nTotal Marks :\t{totalMarks}");

//            percentage = exame.PercentageCalculation();
//            Console.WriteLine($"\nPercentage :\t{percentage}%");

//            result = exame.ExameResultStatus();
//            Console.WriteLine($"\n{student.Name}\t{result} in the examination");

//        }

//        public void Displaystudentdetails(Student s)
//        {
//            Console.WriteLine($"\nName:\t\t{s.Name}\nStd.:\t\t{s.Std}\nRoll no." +
//                $":\t{s.RollNo}\nBirth date:\t{s.BirthDate.ToShortDateString()}");
//        }

//        //#region Added functionality - used .dll flie and added into COM reference.
//        ////i.e., logic was written by another team in different project & we are using its functionality by calling yhe defined method
//        //public static void finalStatement()
//        //{
//        //    GoodByeMessage goodByeMessage = new GoodByeMessage();
//        //    goodByeMessage.PrintAtEnd();
//        //    Console.WriteLine("-------------------------");
//        //}
//        //#endregion

//        #region Method to create Json of 'object of this(Student) class'
//        public string ConvertToJson()
//        {
//            string json = JsonConvert.SerializeObject(this);
//            return json;
//        }

//        public double Exame(bool absentInExame = false)
//        {
//            throw new NotImplementedException();
//        }

//        public double Exame(int mathsMarks, int languageMarks, int socialScienceMarks, int scienceMarks)
//        {
//            throw new NotImplementedException();
//        }

//        public double PercentageCalculation()
//        {
//            throw new NotImplementedException();
//        }

//        public string ExameResultStatus()
//        {
//            throw new NotImplementedException();
//        }
//        #endregion
//    }
//}

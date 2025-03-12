
using Csharp;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Student
    {
        private int rollNo;
        private string name;
        private int std;
        private DateTime birthDate;

        public string[] subjects;

        private int marks;
        private double percentage;
        private bool resultStatus;
        private string passOrFail;

        private const int minimunmarks = 1;

        public static int concessionMarks = 35;

        public static int sportMarks = 5;

        public int MinimumMarks
        {
            get
            {
                return minimunmarks;
            }
            //Not allowed to set a value for a constant varible
            //set
            //{
            //    minimunmarks = value;
            //}
        }

        public string PassOrFali
        {
            get
            {
                return passOrFail;
            }
            set
            {
                passOrFail = value;
            }
        }

        public bool ResultStatus
        {
            get
            {
                return resultStatus;
            }
            set
            {
                resultStatus = value;
            }
        }

        public double Percentage
        {
            get
            {
                return percentage;
            }
            set
            {
                percentage = value;
            }
        }

        public int Marks
        {
            get
            {
                return marks;
            }
            set
            {
                marks = value;
            }
        }

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
        public Student(string name, int std, int rollNo, DateTime birthDate)
        {
            RollNo = rollNo;
            Name = name;
            Std = std;
            BirthDate = birthDate;
        }

        public double Exame(bool absentInExame = false)
        {
            if (absentInExame)
            {
                Marks = 0;
                Console.WriteLine("You was absent in exame.");
            }

            return Exame(minimunmarks,minimunmarks,minimunmarks, minimunmarks);
        }

        public double Exame(int mathsMarks, int languageMarks, int socialScienceMarks, int scienceMarks)
        {
            if ((mathsMarks <= 35) && (languageMarks >= 35 && socialScienceMarks >= 35 && scienceMarks >= 35))
            {
                mathsMarks = concessionMarks;
                ResultStatus = true;
            }
            else if ((languageMarks <= 35) && (mathsMarks >= 35 && socialScienceMarks >= 35 && scienceMarks >= 35))
            {
                languageMarks = concessionMarks;
                ResultStatus = true;
            }
            else if ((socialScienceMarks <= 35) && (languageMarks >= 35 && mathsMarks >= 35 && scienceMarks >= 35))
            {
                socialScienceMarks = concessionMarks;
                ResultStatus = true;
            }
            else if ((scienceMarks <= 35) && (languageMarks >= 35 && socialScienceMarks >= 35 && mathsMarks >= 35))
            {
                scienceMarks = concessionMarks;
                ResultStatus = true;
            }
            PassOrFali = "Fail";
            if (ResultStatus)
            {
                PassOrFali = "Pass";
            }


            //enter the marks obtain in each subject
            Marks = (mathsMarks + languageMarks + socialScienceMarks + scienceMarks);

            Console.WriteLine($"\n{Name}\thas obtain total marks :\t{Marks}\n"); //50+50+50+50=200
            Console.WriteLine($"\n{Name}\tis\t{PassOrFali}\tin this examination."); //50+50+50+50=200

            return marks;

        }

        public double calculateSportsMarks()
        {
            Marks = Marks + sportMarks ;
            Console.WriteLine($"\nAfter adding\t{sportMarks}\tas a standard Sport's participant marks, your total marks are:\t{Marks}");
            return Marks;
        }

        public int calculateSportsMarksForWinners(ref int winnerSportsMarks)
        {
            winnerSportsMarks = 50;
            Marks = Marks + winnerSportsMarks;
            Console.WriteLine($"\nAs your a winner, you will get extra 50 marks. Now your total marks will be\t{Marks}\t");
            return Marks;
        }

        public double Result()
        {
            percentage = (double)Marks * 100  / 400  ; // (200/400)*100 = 0.5 * 100 = 50 %

            Console.WriteLine($"\nYou achive\t{Percentage}%\tin this examination.\n");

            return Percentage;
        }

        //Added functionality - used .dll flie and added into COM reference.
        //i.e., logic was written by another team in different project & we are using its functionality by calling yhe defined method
        public static void finalStatement()
        {
            GoodByeMessage goodByeMessage = new GoodByeMessage();
            goodByeMessage.PrintAtEnd();
            Console.WriteLine("-------------------------");
        }

        public static void UsingACustomType()
        {
            List<string> list = new List<string>();
        }

        public string ConvertToJson()
        {
            string json = JsonConvert.SerializeObject(this);
            return json;
        }

        public void DisplayStudentsDetails()
        {
            Console.WriteLine($"\nName:\t{Name}\nStd.:\t{Std}\nRoll\tno.:\t{RollNo}\nBirth\tdate:\t{BirthDate}");
        }
    }
}

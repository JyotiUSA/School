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
        public int rollNo;
        public string name;
        public int std;
        public DateTime birthDate;

        public string[] subjects;

        public int marks;
        public double percentage;
        public bool resultStatus;
        public string passOrFail;

        public static int concessionMarks = 35;

        public static int sportMarks = 5;

        const int minimunmarks = 1;

        public Student(string studentName, int studentStd, int studentRollNo, DateTime studentbirthDate)
        {
            rollNo = studentRollNo;
            name = studentName;
            std = studentStd;
            birthDate = studentbirthDate;
        }

        public double Exame(bool absentInExame = false)
        {
            if (absentInExame)
            {
                marks = 0;
                Console.WriteLine("You was absent in exame.");
            }

            return Exame(minimunmarks,minimunmarks,minimunmarks, minimunmarks);
        }

        public double Exame(int mathsMarks, int languageMarks, int socialScienceMarks, int scienceMarks)
        {
            if ((mathsMarks <= 35) && (languageMarks >= 35 && socialScienceMarks >= 35 && scienceMarks >= 35))
            {
                mathsMarks = concessionMarks;
                resultStatus = true;
            }
            else if ((languageMarks <= 35) && (mathsMarks >= 35 && socialScienceMarks >= 35 && scienceMarks >= 35))
            {
                languageMarks = concessionMarks;
                resultStatus = true;
            }
            else if ((socialScienceMarks <= 35) && (languageMarks >= 35 && mathsMarks >= 35 && scienceMarks >= 35))
            {
                socialScienceMarks = concessionMarks;
                resultStatus = true;
            }
            else if ((scienceMarks <= 35) && (languageMarks >= 35 && socialScienceMarks >= 35 && mathsMarks >= 35))
            {
                scienceMarks = concessionMarks;
                resultStatus = true;
            }
            passOrFail = "Fail";
            if (resultStatus)
            {
                passOrFail = "Pass";
            }


            //enter the marks obtain in each subject
            marks = (mathsMarks + languageMarks + socialScienceMarks + scienceMarks);

            Console.WriteLine($"\n{name}\thas obtain total marks :\t{marks}\n"); //50+50+50+50=200
            Console.WriteLine($"\n{name}\tis\t{passOrFail}\tin this examination."); //50+50+50+50=200

            return marks;

        }

        public double calculateSportsMarks()
        {
            marks = marks + sportMarks ;
            Console.WriteLine($"\nAfter adding\t{sportMarks}\tas a standard Sport's participant marks, your total marks are:\t{marks}");
            return marks;
        }

        public int calculateSportsMarksForWinners(ref int winnerSportsMarks)
        {
            winnerSportsMarks = 50;
            marks = marks + winnerSportsMarks;
            Console.WriteLine($"\nAs your a winner, you will get extra 50 marks. Now your total marks will be\t{marks}\t");
            return marks;
        }

        public double Result()
        {
            percentage = (double)marks * 100  / 400  ; // (200/400)*100 = 0.5 * 100 = 50 %

            Console.WriteLine($"\nYou achive\t{percentage}%\tin this examination.\n");

            return percentage;
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
            Console.WriteLine($"\nName:\t{name}\nStd.:\t{std}\nRoll\tno.:\t{rollNo}\nBirth\tdate:\t{birthDate}");
        }
    }
}

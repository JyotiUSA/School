using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace School
{
    class ExaminationDepartment : IExaminationDepartment
    {
        private int marks;
        private double percentage;
        private bool resultStatus;
        private string passOrFail;

        private string[] subjects = new string[] { "Maths","language","Social Science","General Science"};
       

        private const int minimunmarks = 1;

        public static int concessionMarks = 35;

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

        

        public string[] Subject
        {
            get { return subjects; }
            set { subjects = value; }
        }

        public string[] getSubjects()
        {
            return Subject;
        }


        //Calculation of marks for absent students
        public double Exame(bool absentInExame = false)
        {
            if (absentInExame)
            {
                Marks = 0;
                Console.WriteLine("You was absent in exame.");
            }

            return Exame(minimunmarks, minimunmarks, minimunmarks, minimunmarks);
        }

        //Calculation of marks
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
            
            return marks;

        }

        //Percentage calculation
        public double PercentageCalculation()
        {
            percentage = (double)Marks * 100 / 400;
            return Percentage;
        }

        public string ExameResultStatus()
        {
            return PassOrFali;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Model
{
    class ExaminationModel
    {
        private double marks;
        private double percentage;
        //private bool resultStatus;
        private string passOrFail;

        private int mathsMarks, languageMarks, socialScienceMarks, scienceMarks;

        private string[] subjects = new string[] { "Maths", "language", "Social Science", "General Science" };


        private const int minimunmarks = 1;

        public static int concessionMarks = 35;

        

        public int MinimumMarks
        {
            get
            {
                return minimunmarks;
            }
            //Not allowed to set a value for a constant varible
            //set {minimunmarks = value;}
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

        //public bool ResultStatus
        //{
        //    get
        //    {
        //        return resultStatus;
        //    }
        //    set
        //    {
        //        resultStatus = value;
        //    }
        //}

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

        public double Marks
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

        public int MathsMarks
        {
            get
            {
                return mathsMarks;
            }
            set
            {
                mathsMarks = value;
            }
        }

        public int ScienceMarks
        {
            get
            {
                return scienceMarks;
            }
            set
            {
                scienceMarks = value;
            }
        }
        public int LanguageMarks
        {
            get
            {
                return languageMarks;
            }
            set
            {
                languageMarks = value;
            }
        }
        public int SocialScienceMarks
        {
            get
            {
                return socialScienceMarks;
            }
            set
            {
                socialScienceMarks = value;
            }
        }


    }
}

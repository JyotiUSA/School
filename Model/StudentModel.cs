using School.API.API_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Model
{
    class StudentModel
    {
        //Models of students conatin all variables and properties

        public static int countStudents = 1;

        private DateTime birthDate;
        private int std;
        private string name;
        private int rollNo;

        public ExaminationModel exameModel { get; set; }

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

        private int[] obtainedMarks = new int[4];
        public int[] ObtainedMarks
        {
            get { return obtainedMarks; }
            set { obtainedMarks = value; }
        }

        public static implicit operator StudentModel(StudentAPI v)
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Student
    {
        public int rollNo;
        public string name;
        public int std;

        public string[] subjects;

        public int marks;
        public double percentage;
        public bool resultStatus;

        const int minimunmarks = 1;

        public Student(string studentName, int studentStd, int studentRollNo)
        {
            rollNo = studentRollNo;
            name = studentName;
            std = studentStd;
        }

        public void Exame()
        {
            //enter the marks obtain in exame
            //Console.WriteLine($"\n {name} \t\t has obtain total marks :\t\t {marks}"); //200
            Exame(minimunmarks,minimunmarks,minimunmarks, minimunmarks);
        }

        public void Exame(int mathsMarks, int languageMarks, int socialScienceMarks, int scienceMarks)
        {
            //enter the marks obtain in each subject
            marks = (mathsMarks + languageMarks + scienceMarks + scienceMarks);
            Console.WriteLine($"\n{name}\t\thas obtain total marks :\t\t{marks}"); //50+50+50+50=200
        }

        public bool Result( bool absentInExame = true)
        {
            percentage = marks * 100  / 400  ; // (200/400)*100 = 0.5 * 100 = 50 %

            Console.WriteLine($"maks --- {marks}");
            Console.WriteLine($"percentage --- {percentage}");


            if (percentage >= 35)
            {
                resultStatus = true;
                Console.WriteLine($"\n{name}\t\tin pass in the Examination.");   //Pass
            }
            else
            {
                resultStatus = false;
                Console.WriteLine($"\n{name}\t\tis fail in the Examination.");   //Fail
            }

            if (absentInExame)
                marks = 0;

            return resultStatus;
        }

        public void DisplayStudentsDetails()
        {
            Console.WriteLine($"\nName:\t\t{name}\nStd.:\t\t{std}\nRoll\tno.:\t\t{rollNo}");
        }
    }
}

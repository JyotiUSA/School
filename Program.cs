using Csharp;
using School;
using School.API.API_Classes;
using School.API.API_Interfaces;
using School.Model;
using System.ComponentModel.Design;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("-------------Students--------------");
Console.WriteLine("-----------------------------------");

//Static variable use for sportsmarks, because those are standard marks for all students9i.e., object of school class.)
//Student.sportMarks = 20;


#region Object Creation at runtime
List<StudentModel> newStudents = new List<StudentModel>();


while (true)
{
    bool newEntry = true;
    string yOrN;
    Console.WriteLine("\nDo you want to enter a new student ( Y | N ):-");
    yOrN = Console.ReadLine();

    if (yOrN.Equals("Y") || yOrN.Equals("y"))
    {
        newEntry = true;

        #region Creating required objects of Student and Examination
        IStudentAPI studentMethod = new StudentAPI();

        StudentModel studentVariable = new StudentModel();

        IExaminationAPI examinationMethod = new ExaminationAPI();

        ExaminationModel examinationVariable = new ExaminationModel();
        #endregion

        #region Collecting Student details
        string[] studentsData = new string[] { "Name", "Std.", "Roll No.", "Birth Date" };

        Console.WriteLine($"\n{StudentModel.countStudents++}. Enter students details:-");

        Console.WriteLine($"Enter {studentsData[0]}:\t");
        studentVariable.Name = (Console.ReadLine());

        Console.WriteLine($"Enter {studentsData[1]}:\t");
        studentVariable.Std = int.Parse(Console.ReadLine());

        Console.WriteLine($"Enter {studentsData[2]}:\t");
        studentVariable.RollNo = int.Parse((Console.ReadLine()));

        Console.WriteLine($"Enter {studentsData[3]}:\t");
        
        studentVariable.BirthDate = DateTime.Parse(Console.ReadLine());
        #endregion

        #region Collecting Marks details
        Console.Write($"\nNow enter your marks as instructed follow:-\n");

        for (int i = 0; i < 4; i++)
        {
            Console.Write($"Enter {examinationVariable.getSubjects()[i]} marks =\t");
            studentVariable.ObtainedMarks[i] = int.Parse(Console.ReadLine());
            if (studentVariable.ObtainedMarks[i] > 100)
            {
                Console.WriteLine("Marks cannot be greater than 100. Please enter the mark again.");
                i -= 1;
            }
        }

        Console.WriteLine("");
        for (int i = 0; i < 4; i++)
        {
            Console.Write($"{examinationVariable.getSubjects()[i]} = {studentVariable.ObtainedMarks[i]} /100 ;\t");
        }

        examinationVariable.MathsMarks = studentVariable.ObtainedMarks[0];
        examinationVariable.LanguageMarks = studentVariable.ObtainedMarks[1];
        examinationVariable.SocialScienceMarks = studentVariable.ObtainedMarks[2];
        examinationVariable.ScienceMarks = studentVariable.ObtainedMarks[3];

        //double totalMarks = examinationMethod.Exame(examinationVariable);
        examinationVariable.Marks = examinationMethod.Exame(examinationVariable);

        examinationVariable.Percentage = examinationMethod.PercentageCalculation(examinationVariable);

        examinationVariable.PassOrFali = examinationMethod.ExameResultStatus(examinationVariable);

        #endregion

        studentVariable.exameModel = examinationVariable;
        //List<StudentModel> newStudents = new List<StudentModel>();
        newStudents.Add(studentVariable);

        foreach (StudentModel s in newStudents)
        {
            Console.WriteLine($"\n\n-------{s.Name}'s Report Card :----------");
            studentMethod.Displaystudentdetails(s);
            Console.WriteLine($"\nTotal Marks :\t{s.exameModel.Marks}");
            Console.WriteLine($"\nPercentage :\t{s.exameModel.Percentage}%");
            Console.WriteLine($"\n{studentVariable.Name} is\t{s.exameModel.PassOrFali} in the examination");
            Console.WriteLine("\n\n-------------------------");
        }

    }
    else if (yOrN.Equals("N") || yOrN.Equals("n"))
    {
        newEntry = false;
        break;
    }
    else
    {
        Console.WriteLine("Type Y or N (for yes or no respectively.)");
        newEntry = false;
    }
}

#endregion


#region Final Display statements
GoodByeMessage goodBye = new GoodByeMessage();
string finalStatement = goodBye.PrintAtEndstring();

Console.WriteLine($"\n{finalStatement}\n==========================\n\nPress any key to exit from this window...");
#endregion

#region File Handling

ReportCard_file.SaveReportCards(newStudents);
ReportCard_file.LoadReportCards();

#endregion

Console.ReadLine();


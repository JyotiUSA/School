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

while (true)
{
    bool newEntry = true;
    string yOrN;
    Console.WriteLine("\nDo you want to enter a new student ( Y | N ):-");
    yOrN = Console.ReadLine();

    if (yOrN.Equals("Y") || yOrN.Equals("y"))
    {
        newEntry = true;
        IStudentAPI studentMethod = new StudentAPI();

        StudentModel studentVariable = new StudentModel();

        IExaminationAPI examinationMethod = new ExaminationAPI();

        ExaminationModel examinationVariable = new ExaminationModel();

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

        List<StudentModel> newStudents = new List<StudentModel>();
        newStudents.Add(studentVariable);
        
        foreach (StudentModel s in newStudents)
        {
            Console.WriteLine($"-------{s.Name}---------");
            studentMethod.Displaystudentdetails(s);
            //int m = examinationMethod.Exame(examinationVariable);
            Console.WriteLine("\n\n-------------------------");
        }
    }
    else
    {
        newEntry = false;
        break;
    }
}
#endregion

//Student.finalStatement();

Console.ReadLine();

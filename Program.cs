using School;
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
        IStudentApi studentapi = new StudentApi();

        Student student = new Student();

        string[] studentsData = new string[] { "Name", "Std.", "Roll No.", "Birth Date" };

        Console.WriteLine($"\n{Student.countStudents++}. Enter students details:-");

        Console.WriteLine($"Enter {studentsData[0]}:\t");
        student.Name = (Console.ReadLine());

        Console.WriteLine($"Enter {studentsData[1]}:\t");
        student.Std = int.Parse(Console.ReadLine());

        Console.WriteLine($"Enter {studentsData[2]}:\t");
        student.RollNo = int.Parse((Console.ReadLine()));

        Console.WriteLine($"Enter {studentsData[3]}:\t");
        student.BirthDate = DateTime.Parse(Console.ReadLine());

        List<Student> students = new List<Student>();
        students.Add(student);
        int a = students.Capacity;
        Console.WriteLine($"No. of students added :-\t{a}");

        foreach (Student s in students)
        {
            Console.WriteLine($"-------{s.Name}---------");
            studentapi.Displaystudentdetails(s);
            studentapi.Examination(s);
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

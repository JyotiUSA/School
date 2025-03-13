using School;
using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("-------------Students--------------");
Console.WriteLine("-----------------------------------");

//Static variable use for sportsmarks, because those are standard marks for all students9i.e., object of school class.)
//Student.sportMarks = 20;

#region Object Creation

Student jyoti = new Student("Jyoti" , 6 , 27, new DateTime(1993,09,16) );

Student tejeshree = new Student("Tejeshree", 12, 53, new DateTime(1981, 08, 24));

Student trishala = new Student("Trishala", 10, 06, new DateTime(1983, 01, 03));

Student ujwala = new Student("Ujwala", 08, 63, new DateTime(1986, 07, 06));

Student bhagyashree = new Student("Bhagyashree", 04, 10, new DateTime(1988, 08, 04));

#endregion

#region List of students object

List<Student> stud = new List<Student>();
stud.Add(jyoti);
stud.Add(tejeshree);
stud.Add(trishala);
stud.Add(ujwala);
stud.Add(bhagyashree);

foreach (Student s in stud)
{
    Console.WriteLine($"-------{s.Name}---------");
    s.DisplayStudentsDetails();
    s.Examination();
    Console.WriteLine("\n\n-------------------------");
}

#endregion

//jyoti.Examination();
Student.finalStatement();

Console.ReadLine();

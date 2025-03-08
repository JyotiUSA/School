using School;

Console.WriteLine("-------------Students--------------");
Console.WriteLine("-----------------------------------");

Student jyoti = new Student("Jyoti" , 6 , 27);

jyoti.DisplayStudentsDetails();

jyoti.Exame();
jyoti.Result();

jyoti.Exame(100, 100, 100, 100);
jyoti.Result();

jyoti.Exame(35, 35, 35, 35);
jyoti.Result();

jyoti.Exame(15, 25, 5, 35);
jyoti.Result();

jyoti.Exame(85, 84, 85, 76);
jyoti.Result();

jyoti.Result(false);


Console.ReadLine();

using School;

//string jyotiAsJson = jyoti.ConvertToJson();
//Console.WriteLine(jyotiAsJson);

Console.WriteLine("-------------Students--------------");
Console.WriteLine("-----------------------------------");

//Static variable use for sportsmarks, because those are standard marks for all students9i.e., object of school class.)
Student.sportMarks = 20;

#region Jyoti Object
//Object Jyoti is created and defined
Student jyoti = new Student("Jyoti" , 6 , 27, new DateTime(1993,09,16) );

//Detailos of jyoti
jyoti.DisplayStudentsDetails();

//Exame marks , will decide are your pass or fail
jyoti.Exame(60, 20, 37, 90);

//All about sports participants
jyoti.calculateSportsMarks();

// Now Winner will wiiner of 6th std. will get 25 marks in sports if they win.
//We are using "ref". To specific std. students, the marks changes now not default marks.
int newSportWinnerMarksFor6Std = 25; 
jyoti.calculateSportsMarksForWinners(ref newSportWinnerMarksFor6Std);

//Calculating Percentages.
jyoti.Result(); //jyoti was present in exame, so no absent need to mention in percentage calculation.

Console.WriteLine($"Thank you {jyoti.name}.....");

#endregion

#region Tejeshree Onject
//Object Tejeshree is created and defined
Student tejeshree = new Student("Tejeshree", 12, 53, new DateTime(1981, 08, 24));

//Detailos of tejeshree
tejeshree.DisplayStudentsDetails();

//Exame marks , will decide are your pass or fail
tejeshree.Exame(91, 15, 30, 25);

//All about sports participants
tejeshree.calculateSportsMarks();

// Now Winner will wiiner of 6th std. will get 25 marks in sports if they win.
//We are using "ref". To specific std. students, the marks changes now not default marks.
int newSportWinnerMarksFor12Std = 30;
tejeshree.calculateSportsMarksForWinners(ref newSportWinnerMarksFor12Std);

//Calculating Percentages.
tejeshree.Result(); //jyoti was present in exame, so no absent need to mention in percentage calculation.

Console.WriteLine($"Thank you {tejeshree.name}.....");

#endregion

Console.ReadLine();

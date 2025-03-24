using School.API.API_Classes;
using School.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class ReportCard_file
    {
        private static string directory = @"D:\Resume2025\C#_Fundamentals\School\";
        private static string file = "ReportCard.txt";

        #region Save Report Card to the file
        internal static void SaveReportCards(List<StudentModel> newStudents)
        {
            string path = $"{directory}{file}";

            //Existance or Creation of Directory
            bool existingFileFound = File.Exists(path);

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(directory);
            }

            //Adding text in File
            StringBuilder sb = new StringBuilder();
            
            foreach (StudentModel s in newStudents)
            {
                ExaminationModel e = new ExaminationModel();
                sb.Append($"Name : {s.Name};");
                sb.Append($"Std. : {s.Std};");
                sb.Append($"Roll No. : {s.RollNo};");

                sb.Append(Environment.NewLine);
            }

            File.WriteAllText(path, sb.ToString());
        }
        #endregion


        #region Load Report Card from the file
        internal static void LoadReportCards()
        {
            string path = $"{directory}{file}";

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine($"\n\nPrint the Report Card from \"{path}\" location.");

            if (File.Exists(path))
            {
                string[] allText = File.ReadAllLines(path);

                for (int i = 0; i < allText.Length; i++)
                {
                    string[] splitData = allText[i].Split(';');
                    string name = splitData[0].Substring(splitData[0].IndexOf(':') + 1);
                    string std = splitData[1].Substring(splitData[1].IndexOf(':') + 1);
                    string rollNo = splitData[2].Substring(splitData[2].IndexOf(':') + 1);

                    Console.WriteLine($"Report card for {name} from Std.{std} :-\n{allText[i]}");
                    Console.ResetColor();
                }
            }
        }
        #endregion
    }
}

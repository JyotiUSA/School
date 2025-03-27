using School.API.API_Classes;
using School.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Files
{
    class ReportCard_file
    {
        private static string directory = @"D:\Resume2025\C#_Fundamentals\School\Files\";
        private static string file = "ReportCard.txt";
        private static string filePass = "ReportCard_passStudents.txt";
        
        #region Save Report Card to the file
        internal static void SaveReportCards(List<StudentModel> newStudents)
        {
            string path = $"{directory}{file}";
            string pathPassedStudents = $"{directory}{filePass}";

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
                sb.Append($"Name : {s.Name};");
                sb.Append($"Std. : {s.Std};");
                sb.Append($"Roll No. : {s.RollNo};");
                sb.Append($"Marks : {s.exameModel.Marks};");
                sb.Append($"Percentage : {s.exameModel.Percentage};");
                sb.Append($"Status : {s.exameModel.PassOrFali};");

                sb.Append(Environment.NewLine);
            }
            File.WriteAllText(path, sb.ToString());

            //Passed students
            bool existingFileFound_pass = File.Exists(pathPassedStudents);

            StringBuilder sb_pass = new StringBuilder();

            foreach (StudentModel sm in newStudents)
            {
                if(sm.exameModel.PassOrFali == "Pass")
                    sb_pass.AppendLine($"Name : {sm.Name}\t promoted to Std. {sm.Std + 1}");
            }
            File.WriteAllText(pathPassedStudents , sb_pass.ToString());
        }
        #endregion


        #region Reading Report Card from the file
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
                    string marks = splitData[3].Substring(splitData[3].IndexOf(':') + 1);
                    string percentage = splitData[4].Substring(splitData[4].IndexOf(':') + 1);
                    string status = splitData[5].Substring(splitData[5].IndexOf(':') + 1);


                    Console.WriteLine($"\n{i}) {name}'s report cards summary:-\t{allText[i]}");
                }
                Console.ResetColor();
            }
        }
        #endregion
    }
}

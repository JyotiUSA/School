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
                sb.AppendLine($"Name : {s.Name}");
                sb.AppendLine($"Std. : {s.Std}");
                sb.AppendLine($"Roll No. : {s.RollNo}");
                sb.AppendLine("-----------------");

                sb.Append(Environment.NewLine);
            }

            File.WriteAllText(path, sb.ToString());
        }
    }
}

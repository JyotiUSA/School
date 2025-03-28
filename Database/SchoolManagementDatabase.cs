using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace School.Database
{
    class SchoolManagementDatabase
    {
        static string connectionString = @"Server=DESKTOP-EKMSCB0\SQLEXPRESS;Database=SchoolManagement;Trusted_Connection=True; TrustServerCertificate = True;";

        public void RetriveDataFromDB()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;

            // Define the query to retrieve all data from the Student table
            string query = "select * from Student";
            string exameQuery = "select * from Exam";

            // Create and open the connection
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    #region Display Students table from database

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Check if the table has any rows
                            if (reader.HasRows)
                            {
                                // Read each row
                                while (reader.Read())
                                {
                                    // Adjust these columns based on your table structure
                                    Console.WriteLine($"ID:{reader["StudentID"]}\tName:{reader["Name"]}\tStd.:{reader["STD"]}\t\tRoll No.:{reader["RollNo"]}\tBirthdate:{reader["BirthDate"]}");
                                }
                            }
                            else
                            {
                                Console.WriteLine("No rows found in the Student table.");
                            }
                        }
                    }
                    #endregion

                    #region Display Exam table from database

                    using (SqlCommand sqlCommand = new SqlCommand(exameQuery , connection))
                    {
                        using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                        {
                            if (dataReader.HasRows)
                            {
                                Console.WriteLine("\nExam details from Database:-");
                                while (dataReader.Read())
                                {
                                    Console.WriteLine($"Exame ID:{dataReader["ExameID"]}\tMarks:{dataReader["Marks"]}\tPercentage:{dataReader["Percentage"]}\tResult Status:{dataReader["PassOrFail"]}");
                                }
                            }
                            else
                                Console.WriteLine("No data found !");
                        }
                    }

                    #endregion
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
            }
            Console.ResetColor();

        }

    }
}

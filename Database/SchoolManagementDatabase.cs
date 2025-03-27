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
            // Define the query to retrieve all data from the Student table
            string query = "select * from Students";
            string exameQuery = "select * from Exam";

            // Create and open the connection
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Connection to SQL Server database was successful!");

                    #region Display Students table from database

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Check if the table has any rows
                            if (reader.HasRows)
                            {
                                Console.WriteLine("Data from Student table:");

                                // Read each row
                                while (reader.Read())
                                {
                                    // Adjust these columns based on your table structure
                                    Console.WriteLine($"\nID:{reader["StudentID"]}\tName:{reader["Name"]}\tStd.:{reader["STD"]}\t\tRoll No.:{reader["RollNo"]}\tBirthdate:{reader["BirthDate"]}");
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
        }

        public int getStudentIdFromStudentTable()
        {
            int studentssID = 100;
            string studentIdQuery = "select Max(StudentID)  from Students";

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand(studentIdQuery , sqlConnection))
                {
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        reader.Read();

                        studentssID = Convert.ToInt32(reader[0]);

                        Console.WriteLine($"\n\nLast Student Id:*****************************************\t{studentssID}");

                    }

                }

            }
            
            return studentssID;
        }

    }
}

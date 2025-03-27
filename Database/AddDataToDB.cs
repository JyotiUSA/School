using Microsoft.Data.SqlClient;
using School.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Database
{
    class AddDataToDB
    {
        //int studentId = 25;
        private int studentID;
        private DateTime birthDate;
        private int std;
        private string name;
        private int rollNo;

        public int StudentID{ get; set; }

        public DateTime BirthDate
        {
            get
            {
                return birthDate;
            }
            set
            {
                birthDate = value;
            }
        }

        public int Std
        {
            get
            {
                return std;
            }
            set
            {
                std = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public int RollNo
        {
            get
            {
                return rollNo;
            }
            set
            {
                rollNo = value;
            }
        }



        public void sqlDataAdd()
        {
            //StudentModel studentVariable = new StudentModel();
            string connectionString = @"Server=DESKTOP-EKMSCB0\SQLEXPRESS;Database=SchoolManagement;Trusted_Connection=True; TrustServerCertificate = True;";
            
            // SQL query to insert data            
            string insertQuery = "INSERT INTO Students (StudentID , Name , Std , RollNo , BirthDate) VALUES (@StudentID , @Name , @Std , @RollNo , @BirthDate)\n";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("StudentID", StudentID);
                        command.Parameters.AddWithValue("Name", Name);
                        command.Parameters.AddWithValue("Std", Std);
                        command.Parameters.AddWithValue("RollNo", RollNo);
                        command.Parameters.AddWithValue("BirthDate", BirthDate);

                        //int rowsAffected = command.ExecuteNonQuery();

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
            }

        }
    }
}

using System;
using System.Data.SqlClient;
using System.IO;

class GenerateCSVReport
{
    static void Main()
    {
        string connectionString = "your_connection_string_here";
        string query = "SELECT EmployeeID, Name, Department, Salary FROM Employees";
        string outputFile = "employee_report.csv";

        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                using (StreamWriter writer = new StreamWriter(outputFile))
                {
                    writer.WriteLine("Employee ID,Name,Department,Salary");

                    while (reader.Read())
                    {
                        string employeeID = reader["EmployeeID"].ToString();
                        string name = reader["Name"].ToString();
                        string department = reader["Department"].ToString();
                        string salary = reader["Salary"].ToString();

                        writer.WriteLine(employeeID + "," + name + "," + department + "," + salary);
                    }
                }
            }

            Console.WriteLine("CSV report generated: " + outputFile);
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
    }
}
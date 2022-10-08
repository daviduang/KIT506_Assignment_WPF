using System;
using System.Collections;
using System.Collections.Generic;
using KIT506_Assignment_WPF.Model;
using MySql.Data.MySqlClient;

namespace KIT506_Assignment_WPF.Database
{
    /* Adapter class for researchers */
    public class ResearcherAdapter : RAPAdapter
    {

        /* Retrieve functions */

        // Retrieve all researchers
        public List<Researcher> allResearchers()
        {
            List<Researcher> researchers = new List<Researcher>();
            string query = "select * from researcher";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                if ((string)reader["type"] == "Staff") {
                    Staff staff = new Staff
                    {
                        id = (int)reader["id"],
                        given_name = (string)reader["given_name"],
                        family_name = (string)reader["family_name"],
                        title = (string)reader["title"],
                        type = Researcher.Type.Staff,
                        level = (Staff.Level)Enum.Parse(typeof(Staff.Level), (string)reader["level"]),
                    };

                    researchers.Add(staff);
                }
      
                else
                {
                    Student student = new Student
                    {
                        id = (int)reader["id"],
                        given_name = (string)reader["given_name"],
                        family_name = (string)reader["family_name"],
                        title = (string)reader["title"],
                        type = Researcher.Type.Student,
                    };

                    researchers.Add(student);
                }
            }
            return researchers;
        }

        /* Add functions */

        /* Update functions */

        /* Remove functions */
    }
}


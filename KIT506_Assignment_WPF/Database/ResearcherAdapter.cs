using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using KIT506_Assignment_WPF.Model;
using MySql.Data.MySqlClient;
using static KIT506_Assignment_WPF.Model.Staff;

namespace KIT506_Assignment_WPF.Database
{
    /* Adapter class for researchers */
    public class ResearcherAdapter : RAPAdapter
    {

        /* Retrieve functions */

        // Retrieve all researchers
        public List<Researcher> getAllResearchers()
        {
            connection.Open();
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
                        level = (Level)Enum.Parse(typeof(Level), (string)reader["level"]),
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

            connection.Close();

            return researchers;
        }

        // Retrieve full details from a researcher by id
        public Researcher getOneResearcher(int id)
        {
            connection.Open();
            string query = "select * from researcher where id = " +id;

            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();

            Researcher researcher = new Researcher();

            // Adding additional attributes based on the type of researcher
            if ((string)reader["type"] == "Staff")
            {
                researcher = new Staff
                {
                    id = (int)reader["id"],
                    type = (Researcher.Type)Enum.Parse(typeof(Researcher.Type), (string)reader["type"]),
                    given_name = (string)reader["given_name"],
                    family_name = (string)reader["family_name"],
                    title = (string)reader["title"],
                    unit = (string)reader["unit"],
                    campus = (Researcher.Campus)Enum.Parse(typeof(Researcher.Campus), ((string)reader["campus"]).Replace(" ", "")),
                    email = (string)reader["email"],
                    photo = (string)reader["photo"],
                    utas_start = (DateTime)reader["utas_start"],
                    current_start = (DateTime)reader["current_start"],
                    level = (Level)Enum.Parse(typeof(Level), (string)reader["level"]),
                };
            }
            else
            {
                researcher = new Student
                {
                    id = (int)reader["id"],
                    type = (Researcher.Type)Enum.Parse(typeof(Researcher.Type), (string)reader["type"]),
                    given_name = (string)reader["given_name"],
                    family_name = (string)reader["family_name"],
                    title = (string)reader["title"],
                    unit = (string)reader["unit"],
                    campus = (Researcher.Campus)Enum.Parse(typeof(Researcher.Campus), ((string)reader["campus"]).Replace(" ", "")),
                    email = (string)reader["email"],
                    photo = (string)reader["photo"],
                    utas_start = (DateTime)reader["utas_start"],
                    current_start = (DateTime)reader["current_start"],
                    supervisor_id = (reader["supervisor_id"] == null) ? (int)reader["supervisor_id"] : 0,
                    degree = (reader["degree"] == DBNull.Value) ? "" : (string)reader["degree"],
                };
            };

            connection.Close();
            return researcher;
        }

        /* Add functions */

        /* Update functions */

        /* Remove functions */
    }
}


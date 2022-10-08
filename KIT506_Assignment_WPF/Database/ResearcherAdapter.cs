using System;
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
                Researcher researcher = new Researcher {
                    id = (int)reader["id"],
                    type = (Researcher.Type) Enum.Parse(typeof(Researcher.Type), (string)reader["type"]),
                    given_name = (string)reader["given_name"],
                    family_name = (string)reader["family_name"],
                    title = (string)reader["title"],
                    level = (reader["level"] == DBNull.Value) ? "" : (string)reader["level"],
                   
                };
                researchers.Add(researcher);
            }
            return researchers;
        }
        public Researcher getOneResearcher(string id)
        {
            List<Researcher> researchers = new List<Researcher>();
            string query = "select * from researcher where id = "+id;
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            Researcher researcher = new Researcher
            {
                id = (int)reader["id"],
                type = (Researcher.Type)Enum.Parse(typeof(Researcher.Type), (string)reader["type"]),
                given_name = (string)reader["given_name"],
                family_name = (string)reader["family_name"],
                title = (string)reader["title"],
                level = (reader["level"] == DBNull.Value) ? "" : (string)reader["level"],
                utas_start = (DateTime)reader["utas_start"],
                current_start = (DateTime)reader["current_start"],
            };
            return researcher;
        }
        /* Add functions */

        /* Update functions */

        /* Remove functions */
    }
}


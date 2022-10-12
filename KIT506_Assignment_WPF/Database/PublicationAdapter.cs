using KIT506_Assignment_WPF.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows;
using static KIT506_Assignment_WPF.Model.Staff;

namespace KIT506_Assignment_WPF.Database
{
    public class PublicationAdapter : RAPAdapter
    {
        private RAPAdapter db;

        /* Constructor */
        public PublicationAdapter()
        {
            this.db = new RAPAdapter { };
        }

        /* Retrieve functions */
        public List<Publication> getPublications(int researcherId)
        {
            connection.Open();
            List<Publication> publications = new List<Publication>();
            
            string query = "select publication.*, researcher_publication.researcher_id " +
                           "from publication " +
                           "inner join researcher_publication " +
                           "on researcher_publication.doi = publication.doi " +
                           "where researcher_id = "+researcherId;

            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Publication publication = new Publication
                {
                    doi = (string)reader["doi"],
                    title = (string)reader["title"],
                    authors = (string)reader["authors"],
                    year = Int32.Parse(reader["year"].ToString()),
                    type = (Publication.Type)Enum.Parse(typeof(Publication.Type), (string)reader["type"]),
                    cite_as = (string) reader["cite_as"],
                    avaliable = (DateTime) reader["available"],
                };
                //MessageBox.Show(publication.type.GetType());
                publications.Add(publication);

            }
            
            connection.Close();

            return publications;
        }



        /* Add functions */

        /* Update functions */

        /* Remove functions */
    }
}


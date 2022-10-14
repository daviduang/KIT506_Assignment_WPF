using KIT506_Assignment_WPF.Database;
using KIT506_Assignment_WPF.Model;
using System.Linq;
using System;
using System.Collections.Generic;

namespace KIT506_Assignment_WPF.Controller
{
    public class PublicationController
    {

        // Store a database connection
        public PublicationAdapter db;
        public PublicationController()
        {
            // Connect to researcher database
            this.db = new PublicationAdapter { };
        }

        // Get Publicataions by researcher
        public int getPublications(Researcher researcher)
        {
            List<Publication> publications = db.getPublications(researcher.id);
            return publications.Count;
        }

        // Get 3-year average by researcher
        public double getAverage(Researcher researcher)
        {
            List<Publication> publications = db.getPublications(researcher.id);

            int currentYear = DateTime.Now.Year;

            // Get the number of publications from previous three years
            List<Publication> threeYearPublication =
                (from publication in publications
                 where publication.year < currentYear && publication.year > currentYear - 4
                 select publication).ToList();

            return threeYearPublication.Count / 3;
        }


        // Get performance by researcher
        public double getPerformance(Researcher researcher)
        {
            double average = getAverage(researcher);

            // Create a Dictionary of performance expectation
            Dictionary<Staff.Level, double> performance = new Dictionary<Staff.Level, double>();
            performance.Add(Staff.Level.A, 0.5);
            performance.Add(Staff.Level.B, 1);
            performance.Add(Staff.Level.C, 2);
            performance.Add(Staff.Level.D, 3.2);
            performance.Add(Staff.Level.E, 4);

            return average / performance[((Staff)researcher).level];
        }



    }
}


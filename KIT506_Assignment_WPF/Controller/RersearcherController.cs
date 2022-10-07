using System;
using System.Collections.Generic;
using KIT506_Assignment_WPF.Database;
using KIT506_Assignment_WPF.Model;

namespace KIT506_Assignment_WPF.Controller
{
    public class ResearcherController
    {
        // Create list of researchers
        public List<Researcher> researchers;

        // Initialise the lise of researchers
        public ResearcherController()
        {
            // Connect to researcher database
            ResearcherAdapter db = new ResearcherAdapter {};

            this.researchers = db.allResearchers();
        }

        // Filter Researchers List by Level
        public List<Researcher> filterByLevel(string level)
        {

            Console.WriteLine(level); // dele

            List<Researcher> filtered_researchers = new List<Researcher>();


            foreach (Researcher researcher in this.researchers)
            {
                Console.WriteLine(researcher.level); // dele


                if (researcher.level == level)
                {

                    filtered_researchers.Add(researcher);
                }
            }

            return filtered_researchers;
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using KIT506_Assignment_WPF.Database;
using KIT506_Assignment_WPF.Model;

namespace KIT506_Assignment_WPF.Controller
{
    public class ResearcherController
    {
        // Create list of researchers
        public List<Researcher> researchers;

        // Create a db connection
        ResearcherAdapter db;

        // Initialise the lise of researchers
        public ResearcherController()
        {
            // Connect to researcher database and initalise the de
            this.db = new ResearcherAdapter {};
            this.researchers = db.allResearchers();
        }

        // Display all researchers
        public List<Researcher> allResearchers()
        {
            return this.researchers;
        }

        // Display all students
        public List<Researcher> allStudents()
        {

            // Generate a filtered researcher list
            List<Researcher> allStudents =
                (from researcher in researchers
                where researcher.type.ToString().Equals("Student")
                select researcher).ToList();

            return allStudents;
        }

        // Filter researcher list by level
        public List<Researcher> filterResearchers(string level)
        {

            // Generate a filtered researcher list
            List<Researcher> filteredResearchers =
                (from researcher in researchers
                where researcher.level == level
                select researcher).ToList();

            return filteredResearchers;
        }

        // Filter researcher by firstname or lastname
        public List<Researcher> searchResearchers(string name)
        {
            // Generate a filtered researcher list
            List<Researcher> filteredResearchers =
                (from researcher in researchers
                 where researcher.family_name == name || researcher.given_name == name
                 select researcher).ToList();

            return filteredResearchers;
        }

        // Retrieve all attributes from researcher
        ///public Researcher researcher(int researcherId)
        //{
        //    db.researcher
        //}
    }
}


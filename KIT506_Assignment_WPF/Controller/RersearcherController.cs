using System;
using System.Collections.Generic;
using System.Linq;
using KIT506_Assignment_WPF.Database;
using KIT506_Assignment_WPF.Model;

namespace KIT506_Assignment_WPF.Controller
{
    public class ResearcherController
    {
        // Store a list of researchers from database
        public List<Researcher> researchers;

        // Store a database connection
        public ResearcherAdapter db;

        // Initialise the lise of researchers
        public ResearcherController()
        {
            // Connect to researcher database
            this.db = new ResearcherAdapter {};
            this.researchers = db.getAllResearchers();
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

        // Display all stuffs
        public List<Researcher> allStaffs()
        {

            // Generate a filtered researcher list
            List<Researcher> allStaffs =
                (from researcher in researchers
                 where researcher.type.ToString().Equals("Staff")
                 select researcher).ToList();

            return allStaffs;
        }

        // Get number of supervisions of a staff researcher
        public int getSupervisions(Staff staff)
        {
            List<Researcher> students = allStudents();

            int supervisionsCount = 0;

            // Find if any student is currently supervised by the Staff
            foreach (Researcher student in students) {

                if (((Student)student).supervisor_id == staff.id )
                {
                    supervisionsCount++;
                }
            }

            return supervisionsCount;
        }

        // Get supervisor name of a student researcher
        public string getSupervisorName(Student student)
        {
            // get the supervisor of the student researcher
            Researcher supervisor = getResearcher(student.supervisor_id);

            return supervisor.title + ' ' + supervisor.given_name + ' ' + supervisor.family_name;
        }

        // Filter researcher list by level
        public List<Researcher> filterResearchers(string level)
        {

            // Generate a staff researcher list
            List<Researcher> staffs =
                (from researcher in researchers
                 where researcher.type == Researcher.Type.Staff
                 select researcher).ToList();

            // Generate a filtered researcher list
            List<Researcher> filteredResearchers =
                (from staff in staffs
                 where ((Staff)staff).level.ToString().Equals(level)
                 select staff).ToList();

            return filteredResearchers;
        }

        // Filter researcher list by firstname or lastname
        public List<Researcher> searchResearchers(string name)
        {
            // Generate a filtered researcher list
            List<Researcher> filteredResearchers =
                (from researcher in researchers
                 where researcher.family_name == name || researcher.given_name == name
                 select researcher).ToList();

            return filteredResearchers;
        }

        // Retrieve a full detail researcher by id
        public Researcher getResearcher(int id)
        {
            return db.getOneResearcher(id);
        }

    }
}


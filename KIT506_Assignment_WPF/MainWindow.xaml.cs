using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using KIT506_Assignment_WPF.Controller;
using KIT506_Assignment_WPF.Model;
using KIT506_Assignment_WPF.Database;
using System.Diagnostics;

namespace KIT506_Assignment_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        // Create list of researchers
        public List<Researcher> researchers;

        public MainWindow()
        {
            InitializeComponent();

            // Connect to researcher database adapter
            ResearcherAdapter db = new ResearcherAdapter {};
            this.researchers = db.allResearchers();

            showAllResearchers();
        }

        // Display all researchers
        public void showAllResearchers()
        {
            // Clear researcher list
            ResearchersTable.Items.Clear();

            // Add all researchers into the ResearchersTable
            foreach (Researcher researcher in researchers)
            {
                ResearchersTable.Items.Add(researcher);
            }
        }

        // Display all students
        public void showAllStudents()
        {
            // Clear researcher list
            ResearchersTable.Items.Clear();

            // Generate a filtered researcher list
            IEnumerable<Researcher> filteredResearchers =
                from researcher in researchers
                where researcher.type.ToString().Equals("Student")
                select researcher;

            // Update the ResearchersTable based on the filtered researcher list
            foreach (Researcher researcher in filteredResearchers)
            {
                ResearchersTable.Items.Add(researcher);
            }
        }

        // Filter researcher list by level
        public void filterResearchers(string level)
        {
            // Clear researcher list
            ResearchersTable.Items.Clear();

            // Generate a filtered researcher list
            IEnumerable<Researcher> filteredResearchers =
                from researcher in researchers
                where researcher.level == level
                select researcher;

            // Update the ResearchersTable based on the filtered researcher list
            foreach (Researcher researcher in filteredResearchers)
            {
                ResearchersTable.Items.Add(researcher);
            }
        }

        // Binding events

        // Filter researcher list by level
        private void updateResearcherList(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count > 0)
            {
                int length = e.AddedItems[0].ToString().Length;
                string level = e.AddedItems[0].ToString().Substring(length-1, 1);

                filterResearchers(level);
            }
        }

        // Show all researchers
        private void clickShowRearchers(object sender, RoutedEventArgs e)
        {
            showAllResearchers();
        }

        // Show student only
        private void clickShowStudents(object sender, RoutedEventArgs e)
        {
            showAllStudents();
        }

    }


}

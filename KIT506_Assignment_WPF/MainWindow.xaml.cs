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
        ResearcherController controller;

        public MainWindow()
        {
            InitializeComponent();

            // Initialise researcher list view
            this.controller = new ResearcherController {};

            // Display all researchers
            List<Researcher> researchers = controller.allResearchers();
            updateResearcherListView(researchers);
        }

        // Update researcher list view base on a researcher list
        private void updateResearcherListView(List<Researcher> researchers)
        {
            // Clear researcher list
            ResearchersTable.Items.Clear();

            // Add all researchers into the ResearchersTable
            foreach (Researcher researcher in researchers)
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

                List<Researcher> filteredResearchers = controller.filterResearchers(level);
                updateResearcherListView(filteredResearchers);
            }
        }

        // Show all researchers
        private void clickShowRearchers(object sender, RoutedEventArgs e)
        {
            updateResearcherListView(controller.allResearchers());
        }

        // Show student only
        private void clickShowStudents(object sender, RoutedEventArgs e)
        {
            updateResearcherListView(controller.allStudents());
        }

    }


}

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
using System.Diagnostics;

namespace KIT506_Assignment_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Initialise researcher list controller
        ResearcherController controller = new ResearcherController ();

        // Initialise researcher detail page view
        ResearcherDetailPage researcherDetailPage;

        public MainWindow()
        {
            InitializeComponent();

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
        private void selectResearcherList(object sender, SelectionChangedEventArgs e)
        {
            // If the selected item list is not empty
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

        // Search researcher by firstname or lastname
        private void clickSearchButton(object sender, RoutedEventArgs e)
        {

            // retrieve the searched researcher list
            List<Researcher> searchedResearchers = controller.searchResearchers(SearchFieldName.Text);

            // if the searched researcher list is empty, display a no found message
            if (searchedResearchers.Count == 0)
            {
                MessageBox.Show("No Result Found");
            }
            else
            {
                updateResearcherListView(searchedResearchers);
            }
        }


        // Show Researcher details page
        private void ResearchersTable_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // If the selected item list is not empty
            if (e.AddedItems.Count > 0)
            {
                // Get selected researcher's id
                int researcherId = ((Researcher)e.AddedItems[0]).id;

                // Initialise the Researcher Detail Page
                researcherDetailPage = new ResearcherDetailPage(researcherId);
                researcherDetailPage.Show();
            }
        }
    }


}

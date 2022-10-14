using KIT506_Assignment_WPF.Controller;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Shapes;

using KIT506_Assignment_WPF.Model;

namespace KIT506_Assignment_WPF
{
    /// <summary>
    /// Interaction logic for ResearcherDetailPage.xaml
    /// </summary>
    public partial class ResearcherDetailPage : Window
    {
        // Stores the researcher
        public Researcher researcher;

        // Initialise researcher controller
        private ResearcherController researcherController = new ResearcherController();

        // Initialise publication controller
        private PublicationController publicationController = new PublicationController();

        public ResearcherDetailPage(int researcherId)
        {
            InitializeComponent();

            this.researcher = researcherController.getResearcher(researcherId);
            researcher.publications = publicationController.getPublications(researcher);

            // If the researcher is staff, drop the staff block
            if (this.researcher.type == Researcher.Type.Staff)
            {
                GridStudent.Children.Clear();
                ((Staff)researcher).threeYearAverage = publicationController.getAverage(researcher);
                ((Staff)researcher).performance = publicationController.getPerformance(researcher);
                ((Staff)researcher).supervisions = researcherController.getSupervisions((Staff)researcher);
            }

            // If the researcher is student, drop the student block
            else
            {
                GridStaff.Children.Clear();
                ((Student)researcher).supervisor_name = researcherController.getSupervisorName((Student)researcher);
            }

            ResearcherDetailsPanel.DataContext = researcher;
        }
    }
}

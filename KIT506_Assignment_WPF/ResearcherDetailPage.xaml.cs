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
        public int researcherId;

        // Initialise researcher list controller
        private ResearcherController controller = new ResearcherController();

        public ResearcherDetailPage(int researcherId)
        {
            InitializeComponent();

            this.researcherId = researcherId;

            Researcher researcher = controller.getResearcher(researcherId);

            Debug.WriteLine(researcher.family_name);
        }
    }
}

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
using System.Windows.Shapes;
using KIT506_Assignment_WPF.Controller;
using KIT506_Assignment_WPF.Model;

namespace KIT506_Assignment_WPF
{
    /// <summary>
    /// Researcher_Report.xaml 的交互逻辑
    /// </summary>
    public partial class Researcher_Report : Window
    {
        //ResearcherController controller;
        public Researcher_Report()
        {
            InitializeComponent();
          //  this.controller = new ResearcherController { };

            // Display all researchers
            //List<Researcher> researchers = controller.allResearchers();
            
        }

      

        
    }
}

using System;
using System.Collections;
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
using KIT506_Assignment_WPF.Controller;
using KIT506_Assignment_WPF.Model;

namespace KIT506_Assignment_WPF
{
    /// <summary>
    /// Researcher_Report.xaml 的交互逻辑
    /// </summary>
    public partial class Researcher_Report : Window
    {
        // Initialise researcher list controller
        ResearcherController researcherController = new ResearcherController();
        // Initialise publication list controller
        PublicationController publicationController = new PublicationController();

        List<Staff> staffs = new List<Staff>();
        List<Researcher> researchers = new List<Researcher>();
        List<Staff> newList = new List<Staff>();
        public Researcher_Report()
        {
            InitializeComponent();
            researchers = researcherController.allStaffs();

            foreach (Researcher researcher in researchers)
            {
                Staff staff = (Staff)researcher;
                staff.performance = publicationController.getPerformance(researcher);
                staffs.Add(staff);
                //MessageBox.Show(staff.performance.ToString());
            }


        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (this.StarPerformance.IsSelected)
            {
                updateStarPerformance(staffs);
            }
            else if (this.BlowExpectation.IsSelected)
            {
                updateBelowExpectation(staffs);
            }
            else if (this.MeetingMinimun.IsSelected)
            {
                updateMeetingMinimum(staffs);
            }
            else if (this.Poor.IsSelected)
            {
                updatePoor(staffs);
            }
        }

        private void updateStarPerformance(List<Staff> researchers)
        {
            this.StarPerformanceGrid.Items.Clear();
            newList =
                (from researcher in researchers
                 where researcher.performance >= 2
                 orderby researcher.performance
                 select researcher).ToList();

            foreach (Staff staff in newList)
            {
                this.StarPerformanceGrid.Items.Add(staff);
            }

        }
        private void updateMeetingMinimum(List<Staff> researchers)
        {
            this.MeetingMinimunGrid.Items.Clear();
            newList =
                (from researcher in researchers
                 where researcher.performance >= 1.1
                 orderby researcher.performance
                 select researcher).ToList();

            foreach (Staff staff in newList)
            {
                this.MeetingMinimunGrid.Items.Add(staff);
            }

        }
        private void updateBelowExpectation(List<Staff> researchers)
        {
            this.BlowExpectationGrid.Items.Clear();
            newList =
                (from researcher in researchers
                 where researcher.performance > 0.7 && researcher.performance < 1.1
                 orderby researcher.performance descending
                 select researcher).ToList();

            foreach (Staff staff in newList)
            {
                this.BlowExpectationGrid.Items.Add(staff);
            }
        }
        private void updatePoor(List<Staff> researchers)
        {
            this.PoorGrid.Items.Clear();
            newList =
                (from researcher in researchers
                 where researcher.performance <= 0.7
                 orderby researcher.performance descending
                 select researcher).ToList();

            foreach (Staff staff in newList)
            {
                this.PoorGrid.Items.Add(staff);
            }

        }

        private void copyEmails(object sender, RoutedEventArgs e)
        {
            string emails = "";
            if (newList.Count != 0)
            {
                foreach (Staff staff in newList)
                {
                    emails += staff.email + ";";
                }
            }
            Clipboard.SetText(emails);

        }

    }
}

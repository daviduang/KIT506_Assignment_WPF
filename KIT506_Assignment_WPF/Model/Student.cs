using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIT506_Assignment_WPF.Model
{
    public class Student:Researcher
    {
        public int supervisor_id { get; set; }
        public string degree { get; set; }

        // Non-database attributes
        public string supervisor_name { get; set; }
    }
}

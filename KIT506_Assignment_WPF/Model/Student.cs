using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIT506_Assignment_WPF.Model
{
    internal class Student:Researcher
    {
        public int supervisor_id { get; set; }
        public string degree { get; set; }
    }
}

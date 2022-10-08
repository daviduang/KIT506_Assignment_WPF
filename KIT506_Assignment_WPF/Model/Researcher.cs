using System;
using System.ComponentModel;

namespace KIT506_Assignment_WPF.Model
{
    public class Researcher
    {
        /* Researcher's enumatations: type, campus and level */
        public enum Type { Student, Staff };
        public enum Campus { Hobart, Launceston, CradleCoast };

        /* Researcher's attributes */
        public int id { get; set; }
        public Type type { get; set; }
        public string given_name { get; set; }
        public string family_name { get; set; }
        public string title { get; set; }
        public string unit { get; set; }
        public Campus campus { get; set; }
        public string email { get; set; }
        public string photo { get; set; }
        public DateTime utas_start { get; set; }
        public DateTime current_start { get; set; }
    }
}


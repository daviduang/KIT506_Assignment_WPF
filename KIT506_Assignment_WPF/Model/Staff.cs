using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIT506_Assignment_WPF.Model
{
    public enum Level { A, B, C, D, E };
    internal class Staff:Researcher
    {
        public Level level { get; set; }
    }
}

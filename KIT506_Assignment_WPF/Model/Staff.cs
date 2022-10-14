using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIT506_Assignment_WPF.Model
{
    public class Staff:Researcher
    {
        public enum Level { A, B, C, D, E };
        public Level level { get; set; }

        // Non-database attributes
        public double threeYearAverage { get; set; }
        public double performance { get; set; }
        public int supervisions { get; set; }
    }
}

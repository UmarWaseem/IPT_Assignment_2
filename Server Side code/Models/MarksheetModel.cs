using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class MarksheetModel
    {
        public double percentage { get; set; }
        public double minMarks { get; set; }
        public double maxMarks { get; set; }
        public string minSubjectMarks { get; set; }
        public string maxSubjectMarks { get; set; }
    }
}

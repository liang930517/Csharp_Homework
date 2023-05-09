using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomePage
{
    class StudentTable3
    {
    }

    public class Student
    {
        public string Name { get; set; }
        public int Total { get; set; }
        public int Average { get; set; }
        public int MaxScore { get; set; }
        public int MinScore { get; set; }
        public List<Subject> SubjectList { get; set; }
    }

    public class Subject
    {
        public string Name { get; set; }
        public int Score { get; set; }
    }

    // ---------------------------------------------------------------------

    public class MyScore
    {
        public string Name { get; set; }
        public int Chinese { get; set; }
        public int English { get; set; }
        public int Math { get; set; }
        public int Total { get; set; }
        public int Average { get; set; }
        public int MaxScore { get; set; }
        public int MinScore { get; set; }
    }

}

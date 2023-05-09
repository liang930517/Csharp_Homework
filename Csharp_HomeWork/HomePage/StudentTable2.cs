using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomePage
{
    class StudentTable2
    {
    }

    public struct StudentScore2
    {
        public string Name { get; set; }
        public int Chinese { get; set; }
        public int English { get; set; }
        public int Math { get; set; }
        //public string Subject { get; set; }

        public StudentScore2(string StudentName, int ChiScore, int EngScore, int MathScore)
        {
            Name = StudentName;
            Chinese = ChiScore;
            English = EngScore;
            Math = MathScore;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomePage
{
    class StudentTable
    {
    }

    public struct StudentScore
    {
        public string Name { get; set; }
        public int Chinese { get; set; }
        public int English { get; set; }
        public int Math { get; set; }

        public StudentScore(string StudentName, int ChiScore, int EngScore, int MathScore)
        {
            Name = StudentName;
            Chinese = ChiScore;
            English = EngScore;
            Math = MathScore;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP1;

namespace OOP2
{
    internal class AnotherClass
    {
        void AnotherMethod()
        {
            GeneratorPro PowerDubi = new GeneratorPro();

        }
    }

    class School
    {
        public int NoOfClassroom { get; set; }
        public string SchoolName { get; set; }

        void Teaching(string teacher, string className)
        {

            Console.WriteLine("Teaching is in progress");
        }

        public int NoOfTerms { get; set; }

        public int Holidays { get; set; }
    }

    class HighSchool : School
    {
        int Flogging(int caneStrength, string studentName)
        {

            return 7;
        }
    }

    class College : School
    {

    }

    class JAMB
    {
        void Apply()
        {
            HighSchool mySchool = new HighSchool();
            mySchool.SchoolName = "FUOYE";
        } 
    }
}

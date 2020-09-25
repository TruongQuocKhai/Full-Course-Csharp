using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Full_Course_Csharp
{
    class Student
    {
        public string name;
        public string major;
        public double gpa;


        // creat constructor
        public Student(string aName, string aMajor, double aGpa)
        {
            name = aName;
            major = aMajor;
            gpa = aGpa;
        }

        public bool hasHonors()
        {
            if (gpa >= 3.5)
            {
                return true;
            }
            return false;
        }
    }

    
}

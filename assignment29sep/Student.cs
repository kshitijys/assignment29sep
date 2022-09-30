using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment29sep
{
    public class Student
    {
        // Student class →rollno,name,percentage,3 subjects marks,calculate total & percentage

        private int rollno, phy, chem, maths,total;
        private string name;
        private double percentage;

        public void AcceptDetails(int rollno, string name, int phy, int chem, int maths)
        {
            this.rollno = rollno;
            this.name = name;   
            this.phy = phy; 
            this.chem = chem;
            this.maths = maths;

        }

        public void calculation()
        {
             total = phy + chem + maths;
            percentage = total / 3;
        }
        public string printdata()
        {
            return $"rollno={rollno} name={name} total={total} percentage={percentage}";
        }

    }
}

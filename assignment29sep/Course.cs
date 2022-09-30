using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment29sep
{
    public class Course
    {

        //Course  → id, course name, fees  -> create 3 objects to display 3 diff courses


        private int Id;
        private string Coursename;
        private float Fees;

        public void Details(int Id, string Coursename, float Fees)
        {
            this.Id = Id;   
            this.Coursename = Coursename;
            this.Fees = Fees;
        }
        public string Showdetails()
        {
            return $" id={Id}  coursename={Coursename} fees={Fees}";
        }
    }
}

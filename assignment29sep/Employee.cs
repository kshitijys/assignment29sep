using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment29sep
{
    public class Employee
    {
        //Employee -> empid, empname & salary


        private int Id;
        private string Name;
        private float Salary;

        public void GetData(int Id,string Name,float Salary)
        {
            this.Id = Id;   
            this.Name = Name;
            this.Salary = Salary;
        }
        public string print()
        {
            return $"id={Id} name={Name} salary={Salary}";
            
        }

    }
}

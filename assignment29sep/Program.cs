using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment29sep
{
    public class Program
    {
        static void Main(string[] args)
        {
            //STUDENT

            //Student s1=new Student();
            //s1.AcceptDetails(101,"kshitij",80,92,80);
            //s1.calculation();
            //Console.WriteLine(s1.printdata()  ); 




            //EMPLOYEE

            //Employee e1=new Employee();
            //e1.GetData(101, "ram", 20000f);
            //Console.WriteLine(e1.print());



            //COURSE

            Course c1=new Course();
            c1.Details(101, "java", 3500);
            Console.WriteLine(c1.Showdetails());


            Course c2 = new Course();
            c2.Details(102, "c#", 4500);
            Console.WriteLine(c2.Showdetails());


            Course c3 = new Course();
            c3.Details(103, "python", 5500);
            Console.WriteLine(c3.Showdetails());

        }
    }
}

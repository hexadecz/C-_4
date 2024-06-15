using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_4_2
{
    class employee
    {
        int empid;
        string name;
        string dateofhire;
        double msalary;

        public string ConvertString(int empid, string name, string dateofhire, double msalary)
        {
            string id = Convert.ToString(empid);
            string salary = Convert.ToString(msalary);
            Console.WriteLine("Employee data:{0} , {1} , {2} , {3}", name, id, salary, dateofhire);
            return name + id + salary + dateofhire;

        }
        public double CalculateTax(double msalary)
        {
            double tax = msalary * 0.1;
            Console.WriteLine("Calculated tax: {0}", tax);

            return tax;
        }
    }   
    internal class Program
    {
        static void Main(string[] args)
        {
            employee m = new employee();
            m.CalculateTax(4000000);
            m.ConvertString(501111, "Ziad", " 20 / 10 / 2015", 4000000); 
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testingMethodsEx
{
    public class Calculations
    {
        public string AddStudent(string fn, string sn)
        {
            // code to add student to a database

            return "Student Added " + fn + " " + sn;
        }

        public double CalNumbers(double x, double y)
        {
            double ans = x * y;
            return ans;
  
        }
    }
}

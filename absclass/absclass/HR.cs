using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace absclass
{
    public class HR : Employee
    {
        public override void calculate_salary(int Annual_salary, int Experience)
        {
            int salary = Annual_salary + (1000 * Experience);
            Console.WriteLine("The total salary of HR is:" + salary);
        }
    }
}

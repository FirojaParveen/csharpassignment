using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace absclass
{
    class Developer : Employee
    {
        public override void calculate_salary(int Annual_salary, int Experience)
        {
            int sal = Annual_salary + (2000 * Experience);
            Console.WriteLine("The total salary of developer is:" + sal);
        }
    }
}

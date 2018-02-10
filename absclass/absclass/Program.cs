using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace absclass
{
    
        public abstract class Employee
        {
         private int Id { get; set; }
         private String Name { get; set; }
        private String Designation { get; set; }
        private int Annual_salary { get; set; }
        private int joining_date { get; set; }
        private int Experience { get; set; }
        public abstract void calculate_salary(int Annual_salary, int Experience); 
       }
    class Program
    {
        static void Main(string[] args)
        {
            HR hr = new HR();
            Developer developer = new Developer();
            hr.calculate_salary(8000, 4);
            developer.calculate_salary(8000, 5);
        }
    }
}
    



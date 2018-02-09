using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventorycomparison
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> mylist = new List<string>(new string[] {
                "Tomato",
            "Potato",
            "ToMato",
            "Potato",
           "Red Tomato",
           "Tomato  Ketchup",
            "Grapes",
             "grapes",
             "potato"
 });
          
            int count = 0;
            var i=0;
            //print how many times string ‘tomato’(case insensititve) is in inventory
            foreach ( string item in mylist)
            {
                int result = string.Compare("tomato",item, StringComparison.OrdinalIgnoreCase);
               if(result==0)
                {
                    count = count + 1;
                }
                
            }
           
           Console.WriteLine("tomato is present " + count + " times in the list");


            //	Print the index of the list where exact “Potato”(case sensitive) word is there
            List<int> index = new List<int>();
            for (i = 0; i < mylist.Count; i++)
            {
                if (mylist[i] == "Potato")
                {
                    index.Add(i);

                }
               
                
            }
            Console.WriteLine("potato is present in indexes"); 
            foreach (var item in index)
            {
                Console.Write(item + ",");   
            }
            Console.WriteLine();

        }
    }
}

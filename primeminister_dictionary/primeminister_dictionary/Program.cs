using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primeminister_dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<Int16, string> PrimeministerList = new Dictionary<Int16, string>();

            PrimeministerList.Add(1998, "Atal Bihari Vajpayee");
            PrimeministerList.Add(2014, "Narendra Modi");
            PrimeministerList.Add(2004, "Manmohan Singh");
            //<i>Find the Prime minister of 2004
            var myKey = PrimeministerList.FirstOrDefault(x => x.Key == 2004).Value;

            Console.WriteLine("The Prime Minister of 2004: " + myKey);
            //<ii>Add current prime minister in the dictionary
            Console.WriteLine("After adding current Prime Minister in the dictionary");
            PrimeministerList.Add(2018, "Narendra Modi");
            foreach (KeyValuePair<Int16, string> pml in PrimeministerList)
            {
                Console.WriteLine("Name = {0}, Year = {1}", pml.Value, pml.Key);

            }
            //<iii>.Make a read - only dictionary.
            //<iv>.Sort the dictionary by year
            Console.WriteLine("The Sorted dictionary by year");

            var sortedDict = from entry in PrimeministerList orderby entry.Key ascending select entry;
            foreach (KeyValuePair<Int16, string> pml in sortedDict)
            {
                Console.WriteLine("Name = {0}, Year = {1}", pml.Value, pml.Key);

            }





        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "Boat", "house", "cat", "river", "cupboard" };

            //<i> print the plurals of the words
            Console.WriteLine("print all the plurals of the words in the dictionary");
            Wordsplural(words);
            foreach (string wrds in words)
            {
                Console.WriteLine(wrds);

            }
            //<ii> replace the 2nd word with synonym
            Console.WriteLine("replace the 2nd word with synonym");
           words = words.Select(s => s.Replace("house", "home")).ToArray();
            foreach (string wrds in words)
            {
                Console.WriteLine(wrds);

            }

            //<iii> add e new word and print the length
            Array.Resize(ref words, words.Length + 1);
            words[words.Length - 1] = "success";
            Console.WriteLine("the new array of books is:");
            foreach (string wrds in words)
            {
                Console.WriteLine(wrds);

            }
            Console.WriteLine("the size of the array is" + words.Length);
            //<iv> find all words with length equals to 7
            Console.WriteLine("the words whose length is equal to 7");
            string[] len = Array.FindAll(words, x => x.Length == 7);
            foreach (string wrds in len)
            {
                Console.WriteLine(wrds);

            }
            //<v>print the word in the 3rd position
            Console.WriteLine("print the word in the 3rd position");
            Console.WriteLine(words.ElementAt(2));

            //<vi> print words in ascending order
            Console.WriteLine("print all the words in ascending order");
            Array.Sort<string>(words);

            foreach (string wrds in words)
            {
                Console.WriteLine(wrds);

            }
            //<vii> print the reverse of an array
            Console.WriteLine("print the reverse array");
            Array.Reverse(words);
            foreach (string wrds in words)
            {
                Console.WriteLine(wrds);

            }
        }
    static void Wordsplural(string[] words)
    {
        for (int i = 0; i < words.Length; i++)
        {
            words[i] = words[i] + "s";
        }
    }
      

  }
    }


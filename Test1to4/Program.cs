using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1to4
{
    class Program
    {
        static void Main(string[] args)
        {
            //QUESTION 1
            Console.WriteLine("OLUWATOSIN OYETUBO   \n\n");
            Console.WriteLine("Enter the string: ");
            var theString = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(theString))
            {
                Console.WriteLine("You have entered an empty string");
            }

            var list = theString.GroupBy(x => x).ToList();
            foreach (var y in list)
            {
                Console.WriteLine($"Character {y.Key}: {y.Count()} times");

            }
            //QUESTION 2

            var arr = new string[7] {"sokoto", "kwara","Borno", "Lagos", "Plateau", "Rivers","Taraba"};

            var ascendingList = arr.OrderBy(x => x.Length).ThenBy(y => y.First()).ToList();
            foreach (var z in ascendingList)
            {
                Console.WriteLine($"{z}");
            }

            //Console.ReadKey();

            //QUESTION 3

            Console.WriteLine("Enter the String: ");
            var wordString = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(wordString))
            {
                Console.WriteLine("You have entered an empty String");
            }
            else
            {
                if (wordString.Trim().Length == 1)
                {
                    Console.WriteLine("NEW WORD: " + wordString.Trim());
                }
                else
                {
                    var beginChar = wordString.First();
                    var lastChar = wordString.Last();
                    var middleLetters = wordString.Substring(1, (wordString.Length - 2));
                    var newWord = $"{lastChar}{middleLetters}{beginChar}";
                    Console.WriteLine("NEW WORD: " + newWord);
                }
            }
            //QUESTION 4
            Console.WriteLine("NUMBER 4: \n\n");

            char[] alpabets = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'y', 'z' };
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            char number4InputString = Convert.ToChar(Console.ReadLine());

            //char number4InputString = 'r';

            if (!alpabets.Contains(Char.ToLower(number4InputString)))
            {
                Console.WriteLine("Input is not an alphabet");
            }
            else if (vowels.Contains(Char.ToLower(number4InputString)))
            {
                Console.WriteLine("The alphabet is a vowel");
            }
            else
            {
                Console.WriteLine("The alphabet is a consonant");
            }
          
            Console.ReadKey();
        }

    }
}
            

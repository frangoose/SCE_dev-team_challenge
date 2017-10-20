using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCE_dev_team_challenge
{
    class Program
    {

        public static bool isPalindrome(string phrase) //function to test is string is a palindrome
        {
            string temp = string.Empty; //temporary string for holding the string to be scanned
            foreach (char c in phrase) //removes all punctuation and whitespace from the original string and builds the new string
            {
                if (!char.IsPunctuation(c) && !char.IsWhiteSpace(c))
                {
                    temp = temp + c;
                }   
            }
            temp = temp.ToLower(); //makes string lowercase for correct char comparison
            //Console.WriteLine(temp); //debug
            int begin = 0;
            int end = temp.Length - 1;
            while(begin < end) //scans the string from each side
            {
                //Console.WriteLine("char1: {0}   char2:{1}", temp[begin], temp[end]); //debug
                if (temp[begin] != temp[end]) //checks for palindrome condtions
                {
                    return false;
                }
                begin++; end--;
            }
            return true;
        }

        static void Main(string[] args)
        {
            string inputFile = "input_windows.txt"; //used a variable to store input file's name for later flexibility
            string longSent = string.Empty; //longest sentence
            string longPalin = string.Empty; //longest palindrome
            int strLen = 0; //length of a string
            string[] sentences = System.IO.File.ReadAllLines(inputFile); //reads each line into a separate index of the array called sentences
            List<string> palindromes = new List<string>();

            //Console.WriteLine("Contents of: " + inputFile); //debug
            foreach (string phrase in sentences) //both checks for the new longest sentence and whether each sentence is a palindrome
            {
                if(phrase.Length > strLen)
                {
                    longSent = phrase;
                    strLen = phrase.Length;
                }
                if (isPalindrome(phrase))
                {
                    palindromes.Add(phrase);
                }
                //Console.WriteLine(phrase); //debug
            }
            strLen = 0;
            foreach (string phrase in palindromes) //both checks for the new longest sentence and whether each sentence is a palindrome
            {
                if (phrase.Length > strLen)
                {
                    longPalin = phrase;
                    strLen = phrase.Length;
                }
            }
            //palindromes.ForEach(Console.WriteLine); //debug prints palindrome list
            Console.WriteLine("Longest sentence: \"{0}\"\n", longSent); //write the longest sentence to console
            Console.WriteLine("Number of palindromes: {0}\n", palindromes.Capacity); //write the number of palindromes to console
            Console.WriteLine("Longest palindrome: {0}\n", longPalin); //write the longest palindrome to console
        }
    }
}

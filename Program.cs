using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCE_dev_team_challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputFile = "input_windows.txt"; //used a variable to store input file's name for later flexibility
            string longSent = string.Empty; //longest sentence
            int lenSent = 0; //length of the longest sentence
            string[] sentences = System.IO.File.ReadAllLines(inputFile); //reads each line into a separate index of the array called sentences

            //Console.WriteLine("Contents of: " + inputFile); //debug
            foreach (string phrase in sentences) //
            {
                if(phrase.Length > lenSent)
                {
                    longSent = phrase;
                    lenSent = phrase.Length;
                }
                //Console.WriteLine(phrase); //debug
            }
            Console.WriteLine("Longest sentence: \"" + longSent + "\"");
        }
    }
}

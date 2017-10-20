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
            string[] sentences = System.IO.File.ReadAllLines("input_windows.txt"); //reads each line into a separate index of the array called sentences
            foreach (string phrase in sentences)
            {
                Console.WriteLine(phrase);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;

namespace TheHighScoreTracker
{
    public class TestLoadScoreValues
    {
        public static bool RunTest()
        {
            List<int> scores = Program.LoadScoreValues("high_scores.txt");


            // Tests the situation where the file does not exist
            try
            {
                Program.LoadScoreValues("NotAFile.txt");
                Console.Error.WriteLine("Expected an exception from loading \"NotAFile.txt");
                return false;
            }
            catch
            {}


        
            return false;
        }
    }
}
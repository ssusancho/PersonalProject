using System;
using System.Collections.Generic;
using System.IO;

namespace TheHighScoreTracker
{
    public class TestLoadScoreValues
    {
        public static bool RunTest()
        {
            List<int> scores = Program.LoadScoreValues("test_scores.txt");

            if (scores.Count != 3){
                return false;
            }

            if (scores[0] != 9001)
            {
                return false;
            }


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
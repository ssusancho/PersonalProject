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

            if (scores.Count != 3){
                // TODO(jcollard 2022-02-02): Add a message to the tester stating
                // what went wrong. For example:
                Console.Error.WriteLine($"Failure: Expected the list of scores to have 3 elements but it had {scores.Count}.");
                return false;
            }

            if (scores[0] != 9001)
            {
                // TODO(jcollard 2022-02-02): Add a message to the tester stating
                // what went wrong.
                Console.Error.WriteLine($"Failure: Expected the first score on the list to be 9001 but it was {scores}.");
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

        
            return true;
        }
    }
}
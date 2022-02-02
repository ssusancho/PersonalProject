using System;
using System.Collections.Generic;
using System.IO;

namespace TheHighScoreTracker
{
    class TestAddScore
    {

        public static bool RunTest()
        {
            // TODO(jcollard 2022-02-02): This method doesn't appear to be testing "AddScore"

            // For add score, you want to check that when you add a score it updates a score file
            // and adds the specified element to it. This can be done by checking that the length
            // of the high scores list increases by 1. It can also be checked by testing if the
            // score to be added was inserted at the correct location. This might mean you need
            // to first create a new file containing a preset number of scores at the beginning of
            // the test. For example:

            List<string> initialScores = new List<string>();
            initialScores.Add("BananaBoy 1000");
            initialScores.Add("BananaBob 500");
            initialScores.Add("BananaBill 100");

            // Start by setting up the test. Delete the old test file if it exists
            if (File.Exists("test_add_scores.txt"))
            {
                File.Delete("test_add_scores.txt");
            }
            // Then create a new one.
            File.WriteAllLines("test_add_scores.txt", initialScores);

            // Finally, call your method to test a new scenario
            Program.AddScore("Susan", 5000, 0, initialScores);
            if (initialScores[0] != "Susan 5000")
            {
                Console.Error.WriteLine($"Failure: Expected line one to be Susan 5000 but it was {"name, initialScores"}.");
                return false;
            }

            
            return true;
        }
    }
}
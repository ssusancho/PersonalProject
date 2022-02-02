using System;
using System.Collections.Generic;
using System.IO;

namespace TheHighScoreTracker
{
    public class TestGetScoreValues
    {
        public static bool RunTest()
        {
            List<int> scores = Program.LoadScoreValues("test_scores.txt");
            int result = Program.GetScoreValue("bob 808");
            if (result != 808)
            {
                // TODO(jcollard 2022-02-02): Add a message to the tester stating
                // what went wrong. (See example in TestLoadScoreValues.cs)
                Console.Error.WriteLine($"Failure: Expected scores to be 808 but it was {scores}.");
                return false;
            }

            // TODO(jcollard 2022-02-02): Add a few more test cases.
            result = Program.GetScoreValue("Susan 9001");
            if (result != 9001)
            {
                Console.Error.WriteLine($"Failure: Expected scores to be 9001 but it was {scores}.");
                return false;
            }

            result = Program.GetScoreValue("Hudson 8000");
            if (result != 8000)
            {
                Console.Error.WriteLine($"Failure: Expected scores to be 8000 but it was {scores}.");
                return false;
            }

            result = Program.GetScoreValue("Collard 1");
            if (result != 1)
            {
                Console.Error.WriteLine($"Failure: Expected scores to be 1 but it was {scores}.");
                return false;
            }
            // TODO(jcollard 2022-02-02): When you get to the end of the method, return true.
            // This indicates the test was successful.
            return true;
        }
    }
}
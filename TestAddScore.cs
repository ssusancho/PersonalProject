using System;
using System.IO;

namespace TheHighScoreTracker
{
    class TestAddScore
    {

        public static bool RunTest()
        {
            List<int> scores = Program.LoadScoreValues("test_scores.txt");

            if (scores.Count != 4)
            {
                return false;
            }
            if (scores[2] != 808)
            {
                return false;
            }
            return false;
        }
    }
}
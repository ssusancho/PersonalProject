using System;
using System.IO;

namespace TheHighScoreTracker
{
    class TestFindInsertionPoint
    {
        public static bool RunTest()
        {
            List<int> scores = Program.LoadScoreValues("test_scores.txt");
            
            newScore result = Program.TestFindInsertionPoint("bob 808");
            if (newScore[2] != 808)
            {
                return false;
            }
            
            return false;
        }
    }
}
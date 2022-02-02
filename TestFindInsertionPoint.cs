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
                // TODO(jcollard 2022-02-02): Add a message to the tester stating
                // what went wrong. (See example in TestLoadScoreValues.cs)
                return false;
            }
            
            return false;
        }
    }
}
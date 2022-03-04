using System;
using System.Collections.Generic;
using System.IO;

namespace TheHighScoreTracker
{
    class TestFindInsertionPoint
    {
        public static bool RunTest()
        {
            List<int> scores = new List<int>();
            scores.Add(800);
            scores.Add(500);
            scores.Add(200);
            int result = Program.FindInsertionPoint(scores, 600);
            if (result != 1)
            {
                // TODO(jcollard 2022-02-02): Add a message to the tester stating
                // what went wrong. (See example in TestLoadScoreValues.cs)
                Console.Error.WriteLine($"Failure: Expected new score to be in the second line but it was not.");
                return false;
            }
            result = Program.FindInsertionPoint(scores, 1);
            if (result != 3)
            {
                Console.Error.WriteLine($"Failure: Expected new score to be in the fourth line but it was not.");
               return false;
            }
            
            
            return true;
        }
    }
}
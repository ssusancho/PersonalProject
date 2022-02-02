using System;
using System.IO;

namespace TheHighScoreTracker
{
    public class TestGetScoreValues
    {
        public static bool RunTest()
        {
            int result = Program.GetScoreValue("bob 808");
            if (result != 808)
            {
                return false;
            }
            return false;
        }
    }
}
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
                // TODO(jcollard 2022-02-02): Add a message to the tester stating
                // what went wrong. (See example in TestLoadScoreValues.cs)
                return false;
            }

            // TODO(jcollard 2022-02-02): Add a few more test cases.

            // TODO(jcollard 2022-02-02): When you get to the end of the method, return true.
            // This indicates the test was successful.
            return false;
        }
    }
}
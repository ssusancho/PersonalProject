using System;
using System.Collections.Generic; // Feedback(jcollard 2022-01-28): This allows us to use List
using System.IO; // Feedback(jcollard 2022-01-28): This allows us to use File
using System.Linq; // Feedback(jcollard 2022-01-28): This allows us to convert files to lists

namespace TheHighScoreTracker
{
    class Program
    {
        static void Main(String[] args)
        {
            if (args.Length > 0 && args[0] == "test")
            {
                TestAll();
                return;
            }
            
            // TODO(jcollard 2022-02-11): All that is left to do is connect
            // everything together:
            // 1. Prompt the user to enter their name.
            // 2. Prompt the user to enter their score.
            // 3. Call the methods you wrote and update the high score list.
            // 4. Display all of the high scores

        }

        public static void TestAll()
        {
            bool testLoadScoreValues = TestLoadScoreValues.RunTest();
            Console.WriteLine($"Test LoadScoreValues(filename): {testLoadScoreValues}");

            bool testGetScoreValue = TestGetScoreValues.RunTest();
            Console.WriteLine($"Test GetScoreValue(score): {testGetScoreValue}");

            bool testFindInsertionPoint = TestFindInsertionPoint.RunTest();
            Console.WriteLine($"Test FindInsertionPoint(values, newScore): {testFindInsertionPoint}");

            bool testAddScore = TestAddScore.RunTest();
            Console.WriteLine($"Test AddScore(name, score, insertAt, scores): {testAddScore}");
        }

        /// <summary>
        /// The scores.txt file is stored in two columns. The first column is 
        /// the players name and the second column is the players score. This 
        /// method loads the file and extracts the second column into a List<int>.
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public static List<int> LoadScoreValues(string filename)
        {
            // 1. Check to see if the specified filename exists.
            // 2. If it does not, throw an exception stating the file cannot be loaded
            // 3. Load the file as a List and store it in a variable named, "lines"
            // 4. Create a List called values.
            // 5. Loop through each line
            //     * For each line, use GetScoreValue to extract the second column as an int
            //     * Add the int to values
            // 6. Return values

            // TODO(jcollard 2022-02-09): I would recommend using:
            // `if(File.Exists(filename) == false)` 
            // File.Exists(string) returns true if the file exists and false otherwise.
            if (File.Exists(filename) == false)
            {
                throw new Exception("No such file");
            }
            else
            {
                List<string> lines = File.ReadAllLines(filename).ToList(); // TODO(jcollard 2022-02-09): Use filename instead of "high_scores.txt"
                List<int> values;
                values = new List<int>();

                foreach (string line in lines) // TODO(jcollard 2022-02-09): try foreach (string line in lines)
                {                    
                    values.Add(GetScoreValue(line)); // TODO(jcollard 2022-02-09): You want to do something like: values.Add(GetScoreValue(line));
                }
                return values;
            }

        }

        /// <summary>
        /// This is a helper method which, given a score string of the format "name score",
        /// extracts the score value from the second column, parses it into an int value, 
        /// and finally returns it.
        /// </summary>
        /// <param name="score"></param>
        /// <returns></returns>
        public static int GetScoreValue(string score)
        {
            // 1. Split the specified score string into two strings using ' ' as a delimiter
            // 2. Store the result in a variable called parts
            // 3. Parse the second element as an int int.Parse(parts[1])
            // 4. Return the result
            // Console.WriteLine($"Checking {score}.");

            string[] parts = score.Split(' ');
            string numString = parts[1];
            try
            {
                int scoreNum = int.Parse(numString);
                return scoreNum;
            }
            catch
            {
                throw new Exception($"Not a valid score");
            }
        }

        /// <summary>
        /// Given a list of score values and a newScore to insert into the high scores 
        /// table, returns the index where the new score should be inserted.
        /// </summary>
        /// <param name="values"></param>
        /// <param name="newScore"></param>
        /// <returns></returns>
        public static int FindInsertionPoint(List<int> values, int newScore)
        {
            // 1. Initialize a counter variable, insertAt, to 0.
            // 2. Loop through each value in values
            //     * If the new score is greater than the current value, we should insert above that score so we return insertAt
            //     * Otherwise, the new score should not be inserted above this score so we increment insertAt by 1 and continue.
            // 3. If we reach the end of the list, insertAt should be the length of the list so we return insertAt.
            int insertAt = 0;
            foreach (int score in values)
            {
                if (newScore > score)
                {
                    return insertAt;
                }
                else
                {
                    insertAt += 1;
                }
            }
            return insertAt;
        }

        /// <summary>
        /// Given the name, score, insertion location, and a list of strings containing the current high scores, 
        /// inserts the name and score at the specified location. Then writes the results to "scores.txt".
        /// </summary>
        /// <param name="name"></param>
        /// <param name="score"></param>
        /// <param name="insertAt"></param>
        /// <param name="scores"></param>
        public static void AddScore(String names, int score, int insertAt, List<String> scores)
        {
            //1. Create a string variable entry which will be the new row to add to the high score list.
            // 2. Assign entry to be $"{name} {score}"
            // 3. Insert entry into scores at the index insertAt
            // 4. Use File.WriteLines to write each line of the scores list to the file "scores.txt"

            // return null; // Feedback(jcollard 2022-01-28): cannot return
            // anything from a void method
            string entry = $"{names}{scores}";
            scores.Insert(insertAt, entry);
            File.WriteAllLines("high_scores.txt", scores);
            return;

        }

    }
}
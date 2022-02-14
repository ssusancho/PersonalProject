# Guessing Game Written Response

The format for this document are taken directly from the AP Computer Science
Principles [Student Handout](../support/ap-csp-student-task-directions.pdf).

## 3a

Provide a written response that does all three of the following:

### 3a i.

Describes the overall purpose of the program.

To provide users with a way to keep track of their high score. 

### 3a ii.

Describes what functionality of the program is demonstrated in the video.

This video demonstrates that my program accepts a score and name, and then sorts it in a list of scores. 

### 3a iii.

Describes the input and output of the program demonstrated in the video.

My program receives a name and numeric input from the user and then outputs a list containing that score and name from greatest to least. 

## 3b

Capture and paste two program code segments you developed during the
administration of this task that contain a list (or other collection type) being
used to manage complexity in your program.

### 3b i.

The first program code segment must show how data have been stored in the list.

```csharp
List<string> lines = File.ReadAllLines(filename).ToList(); 
```

### 3b ii.

The second program code segment must show the data in the same list being used,
such as creating new data from the existing data or accessing multiple elements
in the list, as part of fulfilling the program's purpose.

```csharp
List<int> values;
values = new List<int>();

foreach (string line in lines) 
    {                    
        values.Add(GetScoreValue(line)); 
    }
return values;
```

### 3b iii.

Then provide a written response that does all three of the following:

Identifies the name of the list being used in this response

The list is stored in the variable "lines"

### 3b iv.

Describes what the data contained in the list represents in your program

The list represents all of the scores and names already in the program.

### 3b v.

Explains how the selected list manages complexity in your program code by
explaining why your program code could not be written, or how it would be
written differently, if you did not use the list.

If my list did not exist, I would have to create variables to score users name and scores, which limits the amount of inputs I could potentially have making this unmanageable. Using a list allows me to store an infinite number of inputs. 

## 3c.

Capture and paste two program code segments you developed during the
administration of this task that contain a student-developed procedure that
implements an algorithm used in your program and a call to that procedure.

### 3c i.

The first program code segment must be a student-developed procedure that:

- [ ] Defines the procedure's name and return type (if necessary)
- [ ] Contains and uses one or more parameters that have an effect on the functionality of the procedure
- [ ] Implements an algorithm that includes sequencing, selection, and iteration

```csharp
public static List<int> LoadScoreValues(string filename)
        {
            if (File.Exists(filename) == false)
            {
                throw new Exception("No such file");
            }
            else
            {
                List<string> lines = File.ReadAllLines(filename).ToList(); 
                List<int> values;
                values = new List<int>();

                foreach (string line in lines) 
                {                    
                    values.Add(GetScoreValue(line));
                }
                return values;
            }

        }
```

### 3c ii.

The second program code segment must show where your student-developed procedure is being called in your program.

```csharp
List<int> scores = LoadScoreValues("high_scores.txt");
int scoreNum = GetScoreValue($"{name} {score}");
```

### 3c iii.

Describes in general what the identified procedure does and how it contributes to the overall functionality of the program.

The scores.txt file is stored in two columns. The first column is the players name and the second column is the players score. This method loads the file and extracts the second column into a list of integers.

### 3c iv.

Explains in detailed steps how the algorithm implemented in the identified procedure works. Your explanation must be detailed enough for someone else to recreate it.

1. Check to see if the specified filename exists.
2. If it does not, throw an exception stating the file cannot be loaded
3. Load the file as a List and store it in a variable named, "lines"
4. Create a List called values.
5. Loop through each line
    * For each line, use GetScoreValue to extract the second column as an int
    * Add the int to values
6. Return values

## 3d

Provide a written response that does all three of the following:

### 3d i.

Describes two calls to the procedure identified in written response 3c. Each call must pass a different argument(s) that causes a different segment of code in the algorithm to execute.

First call:

LoadScoreValues(filename)

Second call:

LoadScoreValues()

**TODO: Complete this section**

### 3d ii.

Describes what condition(s) is being tested by each call to the procedure

Condition(s) tested by the first call:
 
I am testing if the file, "filename" exists. This will cause the body of the if statement to execute. 

Condition(s) tested by the second call:

I am testing if the file, "" exists. This will skip the body of the if statement. 

### 3d iii.

Result of the first call:

The result of calling a file named "filename" creates a list called values, and separates the second column as an integer. 

Result of the second call:

The result of calling a file named "" causes an exception to be thrown. 
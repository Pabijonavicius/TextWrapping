# TextWrapping
An assigment task - Word Wrap Implementation in C#.

# About The Task
  - Create an algorithmn that wraps given text.
  - Algorithm must accept 2 arguments - (Input Text and Maximum Number of Characters In One Line)
  - Algorithm must split input text into lines in such a way that the length of each line is less or equal to the given maximum length.
  - Break words only if it’s necessary to keep the required line length. 
  - Input text may contain multiple lines.
  - Input text should be read from file.
  - Output text should be written to file.

# Sample (Input | Output):
Case: 1
----------------------
    Input File Contents:
        Lorem Ipsum is simple.
    Max Line Length:
        4
    Output:
        Lore
        m Ip
        sum 
        is s
        impl
        e.
Case: 2
----------------------
    Input File Contents:
        Hello World.
    Max Line Length:
        5000
    Output:
        Hello World.
Case: 3
----------------------
    Input File Contents:
        Hello World.
    Max Line Length:
        -10
    Output:
        Should Crash of invalid length.
        
# Feature List
    N/A.
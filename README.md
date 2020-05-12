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
        Should crash because of invalid length.

# Shortcuts
#First
----------------------
    Decided to implement simple argument validation class,
    it will ensure that passed arguments are valid to use for Word Wrapping:
        - Input file path (First Argument),
        - Max Line Length (Second Argument).
    It would be better to implment some kind of flag attributes, this would provide better usability for example: 
         -i or --input-path: to specify desired input file,
         -m or --max-length: to specify desired maximum line length.
#Second
----------------------
    For faster development decided to process each line manually, better approach maybe would be, to read data in small chunks instead of manually formatting the lines.

# Feature List
    N/A.
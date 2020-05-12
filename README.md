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
#Third
----------------------
    When dumping output, program formats the output path: {inputPath} + {-output.txt}, something better could be done, for example writting to temp file, and then maybe removing original file and renaming temp file which original's file name.
    
    In the task there was no strict rule to represent output in the same file, that's why decided to write outputs to a different file for faster development. 
    
    Also, downside to this, if a file is very large, than a lot of space would be wasted.
    
    Reading data and processing it in chunks, using some kind of buffer would be more efficent but it would take more time to develop.
    
    
# Feature List
### WordWrapper 
 > A class that implements simple word wrapping functionality
 -  WordWrapper.WrapText - handles text wrapping feature
### ArgumentSanitizer 
 > A Helper class responsible for various cmd argument validations.
 - SanitizeArgsArray - Ensures that no more arguments are being passed than it is needed.
 - SanitizeInputPathArgument - Ensures that valid input path is being passed.
 - SanitizeMaxLengthArgument - Ensures that valid maximum length is being passed.

    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
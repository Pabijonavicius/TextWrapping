using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TextWrapping
{
    /// <summary>
    /// WordWrapper class provides needed functionality for word wrapping functionality.
    /// </summary>
    class WordWrapper
    {
        private string outputPath;
        private string inputPath;
        private int maxLength;

        /// <summary>
        /// Initializes a new instance of WordWrapper class 
        /// </summary>
        /// <param name="inputPath">
        /// Actual input path, from where all the data will be processed.
        /// </param>
        /// <param name="maxLength">
        /// Positive integer, maxLength >= 1
        /// </param>
        public WordWrapper(string inputPath, int maxLength)
        {
            this.inputPath = InputPathValidation(inputPath);
            this.maxLength = MaxLengthValidation(maxLength);
            outputPath = GenerateOutputPath();
        }

        /// <summary>
        /// Breaks the line of the provided text accordingly 
        /// to the maxLength of the line allowed.
        /// </summary>
        /// <param name="line">
        /// String attribute which represents a line of text.
        /// </param>
        /// <param name="maxLength">
        /// An integer which specify maximum length of the text line.
        /// </param>
        /// <returns>
        /// The List of strings, that represents wrapped line.
        /// </returns>
        private List<string> WrapLine(string line, int maxLength)
        {
            List<string> lines = new List<string>();
            for (int i = 0; i < line.Length; i += maxLength)
            {
                string l;
                try
                {
                    l = line.Substring(i, maxLength);
                }
                catch
                {
                    l = line.Substring(i);
                }

                lines.Add(l);
            }
            return lines;
        }

        /// <summary>
        /// Reads the input of provided input file path attribute, 
        /// breaks line of text if needed by maxLength attribute,
        /// and writes processed data to the output file path.
        /// </summary>
        public void  WrapText()
        {
            // It would be better for performance, to read data in chunks (using some kind of buffer)
            // Line parsing solution takes additional time, writing directly a chunk should be faster
            try
            {
                using var streamReader = new StreamReader(inputPath);
                using var streamWriter = new StreamWriter(outputPath, false, streamReader.CurrentEncoding);
                string line = streamReader.ReadLine();

                while (line != null)
                {
                    var wrappedLines = WrapLine(line, maxLength);
                    foreach (var l in wrappedLines)
                    {
                        streamWriter.WriteLine(l);
                    }
                    line = streamReader.ReadLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error Occurred...");
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Generates a path, where wrapped text will be written.
        /// </summary>
        /// <returns>
        /// String of output path file.
        /// </returns>
        private string GenerateOutputPath()
        {
            string outputFilename = string.Format("{0}{1}{2}",
                Path.GetFileNameWithoutExtension(inputPath),
                "-output",
                Path.GetExtension(inputPath)
            );
            return Path.Combine(Path.GetDirectoryName(inputPath), outputFilename);
        }

        /// <summary>
        /// Validates if inputPath parameter is valid.
        /// </summary>
        /// <returns>
        /// String of input path.
        /// </returns>
        private string InputPathValidation(string inputPath)
        {
            if (!File.Exists(inputPath))
            {
                throw new Exception("Input file does not exist!");
            }
            return inputPath;
        }
        /// <summary>
        /// Validates if maxLength parameter is valid.
        /// </summary>
        /// <returns>
        /// An Integer of maxLength.
        /// </returns>
        private int MaxLengthValidation(int maxLength)
        {
            if (maxLength <= 0)
            {
                throw new Exception("MaxLength Attribute must higher than 0");
            }
            return maxLength;
        }
    }
}

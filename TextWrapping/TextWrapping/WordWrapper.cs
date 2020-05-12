using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TextWrapping
{
    class WordWrapper
    {
        private string outputPath;
        private string inputPath;
        private int maxLength;

        public WordWrapper(string inputPath, int maxLength)
        {
            this.inputPath = inputPath;
            this.maxLength = maxLength;
            outputPath = GenerateOutputPath();
        }

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
        private string GenerateOutputPath()
        {
            string outputFilename = string.Format("{0}{1}{2}",
                Path.GetFileNameWithoutExtension(inputPath),
                "-output",
                Path.GetExtension(inputPath)
            );
            return Path.Combine(Path.GetDirectoryName(inputPath), outputFilename);
        }
    }
}

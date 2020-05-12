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

        public void WrapText()
        {
            using (var streamReader = new StreamReader(inputPath))
            {
                string line = streamReader.ReadLine();
                var lines = new List<string>();
                while (line != null)
                {
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
                    line = streamReader.ReadLine();
                }
                using (var streamWritter = new StreamWriter(outputPath, false, streamReader.CurrentEncoding))
                {
                    foreach (var l in lines)
                    {
                        streamWritter.WriteLine(l);
                    }
                }
     
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

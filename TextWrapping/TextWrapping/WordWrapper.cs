using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TextWrapping
{
    class WordWrapper
    {
        private string inputPath;
        private int maxLength;

        public WordWrapper(string inputPath, int maxLength)
        {
            this.inputPath = inputPath;
            this.maxLength = maxLength;
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

                foreach (var l in lines)
                {
                    Console.WriteLine(l);
                }
            }
        }
    }
}

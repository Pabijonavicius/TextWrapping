using System;

namespace TextWrapping
{
    class Program
    {
        /// <summary>
        /// Starting point of the application
        /// </summary>
        /// <param name="args">
        /// Program expects 2 arguments:
        ///     First  ) Input file path      -> String
        ///     Second ) Maximum line length  -> Integer
        /// </param>
        static void Main(string[] args)
        {
            try
            {
                ArgumentSanitizer.SanitizeArgsArray(args);
                string inputPath = ArgumentSanitizer.SanitizeInputPathArgument(args[0]);
                int maxLength = ArgumentSanitizer.SanitizeMaxLengthArgument(args[1]);
                var wordWrapper = new WordWrapper(inputPath, maxLength);
                wordWrapper.WrapText();
                Console.WriteLine("Wrapped Text Saved ->" + wordWrapper.outputPath);
                Console.WriteLine("Shuting down...");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

using System;
using System.IO;

namespace TextWrapping
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ArgumentSanitizer.SanitizeArgsArray(args);
                string inputPath = ArgumentSanitizer.SanitizeInputPathArgument(args[0]);
                int maxLength = ArgumentSanitizer.SanitizeMaxLengthArgument(args[1]);

                Console.WriteLine("Shuting down...");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

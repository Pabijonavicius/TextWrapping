using System;
using System.IO;

namespace TextWrapping
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPath;
            int maxLength;
            if(args.Length != 2)
            {
                throw new Exception("Input file path, and maxLength arguments must be passed!");
            }
            if (!File.Exists(args[0]))
            {
                throw new Exception("Input file does not exist!");
            } else
            {
                inputPath = args[0];
            }
            try
            {
                maxLength = Convert.ToInt32(args[1]);
            } 
            catch (Exception e)
            {
                throw new Exception("Converting error..");
            }

            Console.WriteLine(inputPath);
            Console.WriteLine(maxLength);
        }
    }
}

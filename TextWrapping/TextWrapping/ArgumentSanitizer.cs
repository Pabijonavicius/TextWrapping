using System;
using System.IO;

namespace TextWrapping
{

    public static class ArgumentSanitizer
    {
        public static void SanitizeArgsArray(string[] args)
        {
            if (args.Length != 2)
            {
                throw new Exception("Input file path, and maxLength arguments must be passed!");
            }
        }
        public static string SanitizeInputPathArgument(string arg)
        {
            if (!File.Exists(arg))
            {
                throw new Exception("Input file does not exist!");
            }
            return arg;
        }
        public static int SanitizeMaxLengthArgument(string arg)
        {
            int maxLength;

            try
            {
                maxLength = Convert.ToInt32(arg);
            }
            catch
            {
                throw new Exception(
                    string.Format("Argument cannot be converted to integer, argument passed: '{0}'", arg)
                    );
            }


            if (maxLength <= 0)
            {
                throw new Exception(
                    string.Format("MaxLength Attribute must higher than 0, passed: '{0}'", arg)
                    );
            }
            return maxLength;
        }
    }
}

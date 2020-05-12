using System;
using System.IO;

namespace TextWrapping
{
    /// <summary>
    /// This class helps to sanitize inputs 
    /// which must be used later in the program.
    /// </summary>
    public static class ArgumentSanitizer
    {
        /// <summary>
        /// Check args array as a whole if it is acceptable,
        /// if not acceptable, exception will be thrown.
        /// </summary>
        /// <param name="args">
        /// Arguments which are being passed from cmd / terminal
        /// </param>
        public static void SanitizeArgsArray(string[] args)
        {
            if (args.Length != 2)
            {
                throw new Exception("Input file path, and maxLength arguments must be passed!");
            }
        }
        /// <summary>
        /// Checks if provided path file does exists,
        /// if not Exception will be thrown.
        /// </summary>
        /// <param name="arg">
        /// A path of a input file that contains data which will be processed.
        /// </param>
        /// <returns>
        /// A string of input file's path.
        /// </returns>
        public static string SanitizeInputPathArgument(string arg)
        {
            if (!File.Exists(arg))
            {
                throw new Exception("Input file does not exist!");
            }
            return arg;
        }
        /// <summary>
        /// Checks if argument is a number.
        /// </summary>
        /// <param name="arg">
        /// An integer which will specify max chars in one line, the integer must be >= 1 to be acceptable.
        /// </param>
        /// <returns>
        /// An Integer which is higher or equal to 1.
        /// </returns>
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

using System;

namespace SampleApp
{
    /// <summary>  
    ///  This class Evaluates if a number is odd, even or 
    ///  if is divisible by two or three.  
    /// </summary>  
    class Program
    {

        /// <summary>This method evaluates a given number and write the results in the console
        /// </summary>
        /// <param name="index" type="int">Represents the current number to be evaluated</param>
        /// <example> 
        /// This sample shows how to call the <see cref="GetZero"/> method.
        /// <code>
        /// class Program 
        /// {
        ///     static int Main() 
        ///     {
        ///         EvaluateNumber(8);
        ///     }
        /// }
        /// </code>
        /// </example>
        static string EvaluateNumber(int index)
        {
            // Place holder for the message to be printed
            string msg = "The number ";

            if (index % 3 == 0 && index % 2 == 0)
            {
                msg += $"'{index}' is divisible by two and three";
            }
            else if (index % 3 == 0)
            {
                msg += $"'{index}' is odd";
            }
            else if (index % 2 == 0)
            {
                msg += $"'{index}' is even";
            }
            else
            {
                msg += $"'{index}' is odd";
            }
            return msg;
        }
        static void Main(String[] args)
        {
            for (int index = 1; index <= 100; index++)
            {
                string msg = EvaluateNumber(index);
                Console.WriteLine(msg);
            }
        }
    }
}
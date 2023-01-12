using System;

namespace Comments
{
    class Program
    {
        /// XML Comments are used to help provide documentation
        /// They start with triple-slashes and have a special syntax
        /// <summary>
        /// This is the main sample application function
        /// </summary>
        static void Main(string[] args)
        {
            //single line comments start with two slashes and you can have as many as you want
            /* multiple line comment start with a slash and a start
            you can just keep on going until you close it with 
            another */
            Console.WriteLine("Hello World!");

        }
    }
}

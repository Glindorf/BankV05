using System;

namespace BankV05
{
    class Program
    {
        /// <summary>
        /// Her er en lille test, den er sød 
        /// </summary>
        static void Main(string[] args)
        {
            InsertCodeHere theCode = new InsertCodeHere();
            theCode.MyCode();

            Console.WriteLine();
            Console.WriteLine("Press any key to close the program...");

            Console.ReadKey();
        }
    }
}

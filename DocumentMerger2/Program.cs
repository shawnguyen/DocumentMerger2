using System;
using System.IO;

namespace DocumentMerger2
{
    class Program
    {
        static void Main(string[] args)
        {

            String[] inFile = new string[args.Length - 1];
            Array.Copy(args, inFile, args.Length - 1);

            //Open & Read
            try
            {
                foreach (string inFile2 in inFile)
                {
                    StreamReader input = new StreamReader(inFile2);
                    string i1 = input.ReadLine();
                    while (i1 != null)
                    {
                        Console.WriteLine(i1);
                        i1 = input.ReadLine();
                    }
                    input.Close();
                }
            }
            catch (Exception e1)
            {
                Console.WriteLine("Error Reading: " + e1.Message);
            }

            var outFile = args[args.Length - 1];

            //Write
            try
            {
                StreamWriter output = new StreamWriter(outFile);
            }
            catch (Exception e2)
            {
                Console.WriteLine("Error Writing: " + e2.Message);
            }

            //If less than 3 files
            if (args.Length < 3)
            {
                Console.WriteLine("Document Merger 2 <input_file_1> <input_file_2> ... <input_file_n> <output_file>");
                Console.WriteLine("Supply a list of text files to merge followed by the name of the resulting merged text file as command line arguments.");
            }
        }
    }
}

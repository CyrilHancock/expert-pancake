

using compressor_decompressor_csharp.CustomEnCoder;
using compressor_decompressor_csharp.CustomEnCoder.JSONFormatter;
using compressor_decompressor_csharp.MapperChar;
using Microsoft.VisualBasic.FileIO;
using System.Xml.Serialization;

namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Please provide a file name as an argument.");
                return;
            }

            string filePath = args[0];

            // Check if the file exists
            if (!File.Exists(filePath))
            {
                Console.WriteLine($"The file '{filePath}' does not exist.");
                return;
            }
            if(args.Length == 1)
            {
                 Console.WriteLine("Did you forget the type");
                return;

            }
            string compressType= args[1];
            try
            {
            switch (compressType)
            {
                case "-c1":
                    CustomCompress.Compress(filePath);
                    break;
                default:
                        throw new Exception("Did you forget the type");
            }
               
            }
            catch (Exception ex)
            {
                // Handle any errors that might occur during file reading
                Console.WriteLine($"An error occurred while reading the file: {ex.Message}");
            }
    }
    }
   
}

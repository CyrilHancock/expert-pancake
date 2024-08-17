using compressor_decompressor_csharp.CustomEnCoder.JSONFormatter;
using compressor_decompressor_csharp.MapperChar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compressor_decompressor_csharp.CustomEnCoder
{
    internal class CustomCompress
    {
        public static void Compress(string filePath)
        {
            // Read the contents of the file

            FileInfo fileInfo = new FileInfo(filePath);
            string fileName = fileInfo.Name;
            string fileType = fileInfo.Extension.TrimStart('.'); // Extracts the file extension without the dot
            string originalSize = fileInfo.Length.ToString(); // Size in bytes
            string fileSize = (fileInfo.Length / 1024.0).ToString("F2") + " KB"; // Size in
                                                                                 // Serialize to JSON
                                                                                 // Read file contents if needed
            string fileContents = File.ReadAllText(filePath);
            string compressedFileContent = "";
            int count = 0;
            foreach (var item in fileContents)
            {
                count++;
                compressedFileContent += Mapper.Mapping.GetValueOrDefault(item)+",";
                Console.WriteLine(count);
            }
            // Create an instance of JSONFile
            JSONFile jsonFile = new JSONFile(fileType, fileName, originalSize, filePath)
            {
                fileSize = fileSize,
                fileContents = compressedFileContent
            };
            string jsonString = System.Text.Json.JsonSerializer.Serialize(jsonFile, new System.Text.Json.JsonSerializerOptions { WriteIndented = true });

            // Define the output JSON file path
            string jsonFilePath = filePath+"_compressed.json";

            // Write JSON string to the file
            File.WriteAllText(jsonFilePath, jsonString);
            Console.WriteLine($"File details have been written to {jsonFilePath}");
            // Output the file contents to the console

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compressor_decompressor_csharp.CustomEnCoder.JSONFormatter
{
    internal class JSONFile
    {
        public string? fileType  { get; set; }
        public string? fileName { get; set; }

        public string? fileSize { get; set; }

        public string? filePath { get; set; }
        public string? fileContents { get; set; }
        
        public string? orginalSize { get; set; }

        public JSONFile(string fileType,string fileName,string orginalSize,string filePath) {
            this.fileType = fileType;
            this.fileName = fileName;
            this.orginalSize = orginalSize;
            this.filePath = filePath;
        }


    }
}

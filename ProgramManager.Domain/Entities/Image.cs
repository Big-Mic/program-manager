using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramManager.Domain.Entities
{
    public class Image
    {
        public Image()
        {
            
        }
        public Image(string fileName, string filePath, string url)
        {
            FileName = fileName;
            FilePath = filePath;
            Url = url;
        }

        public string FileName { get; set; }
        public string FilePath { get; set; }
        public string Url { get; set; }
    }
}

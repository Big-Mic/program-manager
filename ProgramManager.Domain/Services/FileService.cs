using ProgramManager.Domain.Entities;
using ProgramManager.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramManager.Domain.Services
{
    public class FileService : IFileService
    {
        public FileService()
        {
                
        }
        public async Task<Image> Create(string fileName, string file, string uploadBasePath)
        {
            if (string.IsNullOrEmpty(file) || string.IsNullOrEmpty(fileName))
            {
                return null;
            }

            var fileExtension = new FileInfo(fileName).Extension;
            var trustedFileName = $"{Guid.NewGuid()}{fileExtension}";
           
            string filePath = Path.Combine(uploadBasePath, trustedFileName);
            var fileData = Convert.FromBase64String(file);
            using (var fs = new FileStream(filePath, FileMode.Create))
            {
                fs.Write(fileData);

                return new Image(fileName, filePath, filePath);
            }
        }
    }
}

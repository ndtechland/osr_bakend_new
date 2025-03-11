using Microsoft.AspNetCore.Http;
using Osr.Services.IUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osr.Services.Utilities
{
    public class ImageUpload : IImageUpload
    {
        public string UploadImage(IFormFile file, string folderName)
        {
            var allowedExtensions = new[] { ".jpeg", ".jpg", ".png", ".gif" }; // Removed video extensions
            return UploadFiles(file, folderName, allowedExtensions);
        }

        public string UploadFiles(IFormFile file, string folderName, string[] allowedExtensions)
        {
            DateTime dt = DateTime.Now;

            string savedFileName = $"{Guid.NewGuid()}{dt:yyyyMMddHHmmssfff}";
            string extension = Path.GetExtension(file.FileName);

            if (!allowedExtensions.Contains(extension.ToLower()))
            {
                return "not allowed";
            }

            // Ensure the folder exists
            string folderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", folderName);
            Directory.CreateDirectory(folderPath);

            string filePath = Path.Combine(folderPath, $"{savedFileName}{extension}");

            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                file.CopyTo(fileStream);
            }

            return $"{savedFileName}{extension}";
        }
    }

}

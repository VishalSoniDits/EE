using System;
using System.IO;
using Microsoft.AspNetCore.Http;

namespace EE.Common
{
    public class ImageUpload
    {
        public string UploadImage(string folderPath, string fileName, IFormFile image)
        {
            string basePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot");

            string newFileName = fileName + DateTime.UtcNow.ToString("_yyyy_MM_dd_hh_mm_ss") + Path.GetExtension(image.FileName);
            var path = Path.Combine(folderPath, newFileName);

            bool exists = System.IO.Directory.Exists(folderPath);
            // Check folder exists.
            if (!exists)
            {
                System.IO.Directory.CreateDirectory(folderPath);
            }

            if (image.Length > 0)
            {
                //image.CopyTo(new FileStream(path, FileMode.Create));
                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    image.CopyTo(fileStream);
                    fileStream.Dispose();
                }
            }
            path = path.Replace(basePath, "").Replace("\\", "/");
            return path;
        }
    }
}
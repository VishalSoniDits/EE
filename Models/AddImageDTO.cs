using System;
using Microsoft.AspNetCore.Http;

namespace EE.Models
{
    public class AddImageDTO
    {

        public IFormFile Image_File { get; set; }


        public string Image_Type { get; set; }

        public bool IsActive { get; set; }

        public string ActionPerformedBy { get; set; }
    }

    public class AddImageData
    {
        public string Image_File { get; set; }

        public string Image_Type { get; set; }

        public bool IsActive { get; set; }

        public string ActionPerformedBy { get; set; }
    }
}

﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSolution.ViewModels.Catalog.Firebase
{
    public class FileUploadViewModel
    {
        public IFormFile File { get; set; }

        public string FileName { get; set; }
        public long Size { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public string Source { get; set; }
        public string Extension { get; set; }
    }
}
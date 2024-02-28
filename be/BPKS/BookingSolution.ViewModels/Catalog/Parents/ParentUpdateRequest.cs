﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSolution.ViewModels.Catalog.Parents
{
    public class ParentUpdateRequest
    {
        public string ParentId { get; set; }
        public string? Password { get; set; }
        public string? FullName { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }
        public string? UserUrl { get; set; }
        //public DateOnly? CreaetDate { get; set; }
        public string? Status { get; set; }
    }
}

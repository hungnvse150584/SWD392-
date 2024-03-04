﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSolution.ViewModels.Catalog.Parties
{
    public class PartyCreateRequest
    {
        //public int PartyId { get; set; }
        public Guid PartyHostId { get; set; }
        public string PartyName { get; set; }
        public string Description { get; set; }
        public string PhoneContact { get; set; }
        public string Place { get; set; }
        public double Rate { get; set; }
        public string ThumbnailUrl { get; set; }
        public DateOnly DayStart { get; set; }
        public DateOnly DayEnd { get; set; }
        public DateOnly CreatedDate { get; set; }
        public string PartyStatus { get; set; }

        //public List<FeedBack> PartyTranslation { get; set; }

    }
}

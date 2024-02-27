﻿namespace Booking.Data.Entities
{

    public partial class FeedBack
    {
        public int FeedBackId { get; set; }

        public int? ParentId { get; set; }

        public int? PartyId { get; set; }

        public int? PartyHostId { get; set; }

        public int? Score { get; set; }

        public string? Feedback1 { get; set; }

        public virtual Party? Party { get; set; }
    }
}
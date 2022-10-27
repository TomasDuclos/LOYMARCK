using System;
using System.Collections.Generic;

namespace LOYMARK.Models
{
    public partial class Activity
    {
        public int ActivityId { get; set; }
        public DateTime CreateDate { get; set; }
        public int UserId { get; set; }
        public string Description { get; set; } = null!;
    }
}

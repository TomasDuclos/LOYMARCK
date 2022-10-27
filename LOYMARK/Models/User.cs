using System;
using System.Collections.Generic;

namespace LOYMARK.Models
{
    public partial class User
    {
        public int UserId { get; set; }
        public string FirtsName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Mail { get; set; } = null!;
        public DateTime DateBirth { get; set; }
        public int? Phone { get; set; }
        public string Country { get; set; } = null!;
        public bool IsReceiveInformation { get; set; }
    }
}

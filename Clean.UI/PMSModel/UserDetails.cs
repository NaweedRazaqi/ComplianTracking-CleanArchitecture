using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class UserDetails
    {
        public int Id { get; set; }
        public string PhoneNumber { get; set; }
        public short? RelativeId { get; set; }
        public string RelativeName { get; set; }
        public string RelativePhoneNumber { get; set; }
        public string UserAddress { get; set; }
        public string PhotoPath { get; set; }
        public int UserId { get; set; }

        public virtual Relative Relative { get; set; }
        public virtual AspNetUsers User { get; set; }
    }
}

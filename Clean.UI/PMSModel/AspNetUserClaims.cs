using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class AspNetUserClaims
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string ClaimType { get; set; }
        public string ClaimValue { get; set; }

        public virtual AspNetUsers User { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class ProfileCode
    {
        public int OrganizationId { get; set; }
        public DateTime CurrentYear { get; set; }
        public int Sequence { get; set; }

        public virtual Organization Organization { get; set; }
    }
}

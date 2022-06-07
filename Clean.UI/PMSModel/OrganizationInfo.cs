using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class OrganizationInfo
    {
        public int OrganizationId { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        public virtual Organization Organization { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class PayGroupWiseOrganization
    {
        public int Id { get; set; }
        public int PayGroupWiseId { get; set; }
        public int OrganizationId { get; set; }

        public virtual Organization Organization { get; set; }
        public virtual PayGroupWise PayGroupWise { get; set; }
    }
}

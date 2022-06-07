using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class PayGroupWise
    {
        public PayGroupWise()
        {
            PayGroupWiseOrganization = new HashSet<PayGroupWiseOrganization>();
            PayGroupWiseQueue = new HashSet<PayGroupWiseQueue>();
            PayGroupWiseRank = new HashSet<PayGroupWiseRank>();
        }

        public int Id { get; set; }
        public long BatchId { get; set; }
        public bool IsProvencial { get; set; }

        public virtual Batch Batch { get; set; }
        public virtual ICollection<PayGroupWiseOrganization> PayGroupWiseOrganization { get; set; }
        public virtual ICollection<PayGroupWiseQueue> PayGroupWiseQueue { get; set; }
        public virtual ICollection<PayGroupWiseRank> PayGroupWiseRank { get; set; }
    }
}

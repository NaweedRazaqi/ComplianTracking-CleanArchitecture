using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class PayableDetails
    {
        public long PayableId { get; set; }
        public string Details { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public virtual Payable Payable { get; set; }
    }
}

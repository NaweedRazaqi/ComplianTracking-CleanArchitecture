using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class DueSurvivorLog
    {
        public int Id { get; set; }
        public int DueLogId { get; set; }
        public short TotalSurvivor { get; set; }
        public short PreviousCalculatedSurvivor { get; set; }
        public short NewEligibleSurvivor { get; set; }
        public int PreviousTotalDue { get; set; }

        public virtual DueLog DueLog { get; set; }
    }
}

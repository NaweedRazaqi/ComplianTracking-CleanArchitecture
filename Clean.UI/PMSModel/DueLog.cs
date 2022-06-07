using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class DueLog
    {
        public DueLog()
        {
            DueSurvivorLog = new HashSet<DueSurvivorLog>();
        }

        public int Id { get; set; }
        public int ApplicationId { get; set; }
        public int PreviousDue { get; set; }
        public int NewDue { get; set; }
        public short DueLogTypeId { get; set; }
        public int? AddOnId { get; set; }
        public bool IsPaid { get; set; }
        public DateTime Date { get; set; }

        public virtual AddOn AddOn { get; set; }
        public virtual Application Application { get; set; }
        public virtual DueLogType DueLogType { get; set; }
        public virtual ICollection<DueSurvivorLog> DueSurvivorLog { get; set; }
    }
}

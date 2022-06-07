using System;
using System.Collections.Generic;

namespace Clean.UI.model
{
    public partial class ProcessTrack
    {
        public int Id { get; set; }
        public int? CaseId { get; set; }
        public int? UnitId { get; set; }
        public int? StatusId { get; set; }

        public virtual Case Case { get; set; }
        public virtual Status Status { get; set; }
        public virtual Unit Unit { get; set; }
    }
}

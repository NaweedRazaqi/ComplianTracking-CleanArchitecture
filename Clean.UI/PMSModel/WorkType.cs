using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class WorkType
    {
        public WorkType()
        {
            ServiceRecord = new HashSet<ServiceRecord>();
        }

        public short Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ServiceRecord> ServiceRecord { get; set; }
    }
}

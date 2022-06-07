using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class Status1
    {
        public Status1()
        {
            ProcessTracking = new HashSet<ProcessTracking>();
        }

        public short Id { get; set; }
        public string Name { get; set; }
        public string NameDari { get; set; }
        public string NamePashto { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }

        public virtual ICollection<ProcessTracking> ProcessTracking { get; set; }
    }
}

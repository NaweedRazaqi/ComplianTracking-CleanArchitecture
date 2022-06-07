using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class Module
    {
        public Module()
        {
            ProcessTracking = new HashSet<ProcessTracking>();
            Screen = new HashSet<Screen>();
        }

        public short Id { get; set; }
        public string Name { get; set; }
        public string NameE { get; set; }
        public string Description { get; set; }
        public int? Sorter { get; set; }

        public virtual ICollection<ProcessTracking> ProcessTracking { get; set; }
        public virtual ICollection<Screen> Screen { get; set; }
    }
}

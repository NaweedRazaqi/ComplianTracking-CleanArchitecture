using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class SalaryCycle
    {
        public SalaryCycle()
        {
            RegulationRank = new HashSet<RegulationRank>();
        }

        public short Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<RegulationRank> RegulationRank { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class SalaryType
    {
        public SalaryType()
        {
            AddOnSalaryType = new HashSet<AddOnSalaryType>();
            Cadre = new HashSet<Cadre>();
            RegulationRank = new HashSet<RegulationRank>();
            ServiceRecord = new HashSet<ServiceRecord>();
        }

        public short Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<AddOnSalaryType> AddOnSalaryType { get; set; }
        public virtual ICollection<Cadre> Cadre { get; set; }
        public virtual ICollection<RegulationRank> RegulationRank { get; set; }
        public virtual ICollection<ServiceRecord> ServiceRecord { get; set; }
    }
}

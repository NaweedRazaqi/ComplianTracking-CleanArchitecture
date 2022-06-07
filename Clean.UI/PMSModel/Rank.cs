using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class Rank
    {
        public Rank()
        {
            AddOn = new HashSet<AddOn>();
            PayGroupWiseRank = new HashSet<PayGroupWiseRank>();
            ReEmployment = new HashSet<ReEmployment>();
            Referral = new HashSet<Referral>();
            RegulationRank = new HashSet<RegulationRank>();
            ServiceRecordPositionType = new HashSet<ServiceRecord>();
            ServiceRecordRank = new HashSet<ServiceRecord>();
        }

        public int Id { get; set; }
        public string NameDari { get; set; }
        public string Name { get; set; }
        public string EmployeeCategory { get; set; }
        public decimal? Sorter { get; set; }
        public bool? UsedByCalculation { get; set; }

        public virtual ICollection<AddOn> AddOn { get; set; }
        public virtual ICollection<PayGroupWiseRank> PayGroupWiseRank { get; set; }
        public virtual ICollection<ReEmployment> ReEmployment { get; set; }
        public virtual ICollection<Referral> Referral { get; set; }
        public virtual ICollection<RegulationRank> RegulationRank { get; set; }
        public virtual ICollection<ServiceRecord> ServiceRecordPositionType { get; set; }
        public virtual ICollection<ServiceRecord> ServiceRecordRank { get; set; }
    }
}

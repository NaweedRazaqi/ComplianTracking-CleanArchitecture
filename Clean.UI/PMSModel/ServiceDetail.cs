using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class ServiceDetail
    {
        public int Id { get; set; }
        public int ProfileId { get; set; }
        public int? RegulationId { get; set; }
        public DateTime LastDayOfReceivingSalary { get; set; }
        public DateTime? RegulationInRuledDate { get; set; }
        public DateTime LastJobLeavingDate { get; set; }
        public DateTime? EqualityDate { get; set; }

        public virtual Profile Profile { get; set; }
        public virtual Regulation Regulation { get; set; }
    }
}

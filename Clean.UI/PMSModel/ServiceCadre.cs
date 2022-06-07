using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class ServiceCadre
    {
        public int ServiceRecordId { get; set; }
        public short EducationRankId { get; set; }
        public decimal Amount { get; set; }

        public virtual EducationRank EducationRank { get; set; }
        public virtual ServiceRecord ServiceRecord { get; set; }
    }
}

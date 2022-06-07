using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class ServiceProfessional
    {
        public int ServiceRecordId { get; set; }
        public int EducationDegreeId { get; set; }
        public decimal Amount { get; set; }

        public virtual EducationDegree EducationDegree { get; set; }
        public virtual ServiceRecord ServiceRecord { get; set; }
    }
}

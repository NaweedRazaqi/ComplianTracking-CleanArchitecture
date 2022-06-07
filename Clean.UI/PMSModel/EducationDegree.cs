using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class EducationDegree
    {
        public EducationDegree()
        {
            Professional = new HashSet<Professional>();
            Profile = new HashSet<Profile>();
            RegulationRank = new HashSet<RegulationRank>();
            ServiceProfessional = new HashSet<ServiceProfessional>();
        }

        public int DegreeId { get; set; }
        public string DegreeName { get; set; }
        public string DegreeNameDari { get; set; }
        public string Category { get; set; }

        public virtual ICollection<Professional> Professional { get; set; }
        public virtual ICollection<Profile> Profile { get; set; }
        public virtual ICollection<RegulationRank> RegulationRank { get; set; }
        public virtual ICollection<ServiceProfessional> ServiceProfessional { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class Disability
    {
        public Disability()
        {
            PensionDisabilityDisabilityLevel = new HashSet<PensionDisability>();
            PensionDisabilityDisabilityPlace = new HashSet<PensionDisability>();
            PensionDisabilityDisabilityType = new HashSet<PensionDisability>();
        }

        public short Id { get; set; }
        public string Name { get; set; }
        public short? CategoryCode { get; set; }
        public string Decription { get; set; }

        public virtual ICollection<PensionDisability> PensionDisabilityDisabilityLevel { get; set; }
        public virtual ICollection<PensionDisability> PensionDisabilityDisabilityPlace { get; set; }
        public virtual ICollection<PensionDisability> PensionDisabilityDisabilityType { get; set; }
    }
}

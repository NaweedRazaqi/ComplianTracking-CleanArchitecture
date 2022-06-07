using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class PensionType
    {
        public PensionType()
        {
            PensionDisability = new HashSet<PensionDisability>();
            Referral = new HashSet<Referral>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string NameDari { get; set; }
        public string Category { get; set; }

        public virtual ICollection<PensionDisability> PensionDisability { get; set; }
        public virtual ICollection<Referral> Referral { get; set; }
    }
}

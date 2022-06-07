using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class EducationRank
    {
        public EducationRank()
        {
            Cadre = new HashSet<Cadre>();
            ServiceCadre = new HashSet<ServiceCadre>();
        }

        public short Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Cadre> Cadre { get; set; }
        public virtual ICollection<ServiceCadre> ServiceCadre { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class Department
    {
        public Department()
        {
            Cadre = new HashSet<Cadre>();
            ReEmployment = new HashSet<ReEmployment>();
            Referral = new HashSet<Referral>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string NameDari { get; set; }
        public string NamePashto { get; set; }
        public int? OrganizationId { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<Cadre> Cadre { get; set; }
        public virtual ICollection<ReEmployment> ReEmployment { get; set; }
        public virtual ICollection<Referral> Referral { get; set; }
    }
}

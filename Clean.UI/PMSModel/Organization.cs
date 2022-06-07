using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class Organization
    {
        public Organization()
        {
            AddOn = new HashSet<AddOn>();
            Cadre = new HashSet<Cadre>();
            OrganizationEmployee = new HashSet<OrganizationEmployee>();
            OrganizationOrder = new HashSet<OrganizationOrder>();
            PayGroupWiseOrganization = new HashSet<PayGroupWiseOrganization>();
            Profile = new HashSet<Profile>();
            ReEmployment = new HashSet<ReEmployment>();
            Referral = new HashSet<Referral>();
            RegulationRank = new HashSet<RegulationRank>();
            ServiceRecord = new HashSet<ServiceRecord>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string NameDari { get; set; }
        public string Pashto { get; set; }
        public string Abbreviation { get; set; }
        public bool IsActive { get; set; }
        public int? ParentId { get; set; }

        public virtual OrganizationInfo OrganizationInfo { get; set; }
        public virtual ProfileCode ProfileCode { get; set; }
        public virtual ICollection<AddOn> AddOn { get; set; }
        public virtual ICollection<Cadre> Cadre { get; set; }
        public virtual ICollection<OrganizationEmployee> OrganizationEmployee { get; set; }
        public virtual ICollection<OrganizationOrder> OrganizationOrder { get; set; }
        public virtual ICollection<PayGroupWiseOrganization> PayGroupWiseOrganization { get; set; }
        public virtual ICollection<Profile> Profile { get; set; }
        public virtual ICollection<ReEmployment> ReEmployment { get; set; }
        public virtual ICollection<Referral> Referral { get; set; }
        public virtual ICollection<RegulationRank> RegulationRank { get; set; }
        public virtual ICollection<ServiceRecord> ServiceRecord { get; set; }
    }
}

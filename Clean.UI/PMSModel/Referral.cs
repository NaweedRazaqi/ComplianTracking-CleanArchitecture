using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class Referral
    {
        public long Id { get; set; }
        public int OrganizationId { get; set; }
        public DateTime ReferralDate { get; set; }
        public int RankId { get; set; }
        public int PensionTypeId { get; set; }
        public int? DepartmentId { get; set; }
        public int ProfileId { get; set; }
        public DateTime LastDayOfEmployment { get; set; }
        public string Section { get; set; }
        public bool Active { get; set; }

        public virtual Department Department { get; set; }
        public virtual Organization Organization { get; set; }
        public virtual PensionType PensionType { get; set; }
        public virtual Profile Profile { get; set; }
        public virtual Rank Rank { get; set; }
    }
}

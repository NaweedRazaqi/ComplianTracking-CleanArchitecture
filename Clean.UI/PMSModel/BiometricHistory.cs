using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class BiometricHistory
    {
        public BiometricHistory()
        {
            ProfileNavigation = new HashSet<Profile>();
        }

        public int Id { get; set; }
        public DateTime BiometricDate { get; set; }
        public int ProfileId { get; set; }
        public bool IsNidmatched { get; set; }
        public bool IsActive { get; set; }
        public bool NewBiometric { get; set; }
        public int UserId { get; set; }
        public long BioDataId { get; set; }
        public int FiscalYearId { get; set; }

        public virtual BioData BioData { get; set; }
        public virtual FiscalYear FiscalYear { get; set; }
        public virtual Profile Profile { get; set; }
        public virtual ICollection<Profile> ProfileNavigation { get; set; }
    }
}

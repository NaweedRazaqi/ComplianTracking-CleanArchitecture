using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class BioData
    {
        public BioData()
        {
            BiometricHistory = new HashSet<BiometricHistory>();
        }

        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FatherName { get; set; }
        public string GrandFatherName { get; set; }
        public string Nidnumber { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime IntegrationDate { get; set; }
        public int UserId { get; set; }
        public bool Active { get; set; }
        public string HashKey { get; set; }

        public virtual ICollection<BiometricHistory> BiometricHistory { get; set; }
    }
}

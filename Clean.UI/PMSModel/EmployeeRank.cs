using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class EmployeeRank
    {
        public EmployeeRank()
        {
            OrganizationEmployee = new HashSet<OrganizationEmployee>();
        }

        public short Id { get; set; }
        public string IdentifierDari { get; set; }
        public string IdentifierPashto { get; set; }
        public string IdentifierEnglish { get; set; }

        public virtual ICollection<OrganizationEmployee> OrganizationEmployee { get; set; }
    }
}

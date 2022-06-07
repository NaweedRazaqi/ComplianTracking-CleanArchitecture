using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class OperationType
    {
        public OperationType()
        {
            AuditTrial = new HashSet<AuditTrial>();
        }

        public short Id { get; set; }
        public string Identifier { get; set; }

        public virtual ICollection<AuditTrial> AuditTrial { get; set; }
    }
}

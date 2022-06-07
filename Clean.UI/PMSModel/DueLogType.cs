using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class DueLogType
    {
        public DueLogType()
        {
            DueLog = new HashSet<DueLog>();
        }

        public short Id { get; set; }
        public string Identifier { get; set; }

        public virtual ICollection<DueLog> DueLog { get; set; }
    }
}

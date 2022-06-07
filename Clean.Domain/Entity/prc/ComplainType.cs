using System;
using System.Collections.Generic;

namespace Clean.Domain.Entity.prc
{
    public partial class ComplainType
    {
        public ComplainType()
        {
            Process = new HashSet<Process>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? ProcessTime { get; set; }

        public virtual ICollection<Process> Process { get; set; }
    }
}

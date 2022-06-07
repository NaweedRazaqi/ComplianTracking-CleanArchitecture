using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class ServiceType
    {
        public ServiceType()
        {
            ChartOfAccount = new HashSet<ChartOfAccount>();
            Regulation = new HashSet<Regulation>();
            ServiceRecord = new HashSet<ServiceRecord>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ChartOfAccount> ChartOfAccount { get; set; }
        public virtual ICollection<Regulation> Regulation { get; set; }
        public virtual ICollection<ServiceRecord> ServiceRecord { get; set; }
    }
}

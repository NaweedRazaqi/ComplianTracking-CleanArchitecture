using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class DataCategory
    {
        public DataCategory()
        {
            Application = new HashSet<Application>();
            Batch = new HashSet<Batch>();
            ChartOfAccount = new HashSet<ChartOfAccount>();
        }

        public short Id { get; set; }
        public string Identifier { get; set; }
        public int? LivingStatusId { get; set; }
        public short? EmployeeTypeId { get; set; }
        public string Type { get; set; }

        public virtual EmployeeType EmployeeType { get; set; }
        public virtual Status LivingStatus { get; set; }
        public virtual ICollection<Application> Application { get; set; }
        public virtual ICollection<Batch> Batch { get; set; }
        public virtual ICollection<ChartOfAccount> ChartOfAccount { get; set; }
    }
}

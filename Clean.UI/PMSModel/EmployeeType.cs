using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class EmployeeType
    {
        public EmployeeType()
        {
            DataCategory = new HashSet<DataCategory>();
            Regulation = new HashSet<Regulation>();
        }

        public short EmployeeTypeId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<DataCategory> DataCategory { get; set; }
        public virtual ICollection<Regulation> Regulation { get; set; }
    }
}

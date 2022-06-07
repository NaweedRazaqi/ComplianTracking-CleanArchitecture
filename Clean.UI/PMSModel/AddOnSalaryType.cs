using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class AddOnSalaryType
    {
        public int AddOnId { get; set; }
        public short SalaryTypeId { get; set; }

        public virtual AddOn AddOn { get; set; }
        public virtual SalaryType SalaryType { get; set; }
    }
}

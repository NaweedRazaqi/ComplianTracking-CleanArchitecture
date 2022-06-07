using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class OrganizationOrder
    {
        public int Id { get; set; }
        public int OrganizationId { get; set; }
        public int FiscalYearId { get; set; }
        public short PaymentOrder { get; set; }

        public virtual FiscalYear FiscalYear { get; set; }
        public virtual Organization Organization { get; set; }
    }
}

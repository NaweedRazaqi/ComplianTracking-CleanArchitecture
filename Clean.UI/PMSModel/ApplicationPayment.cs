using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class ApplicationPayment
    {
        public long Id { get; set; }
        public int ApplicationId { get; set; }
        public int FiscalYearId { get; set; }
        public bool PaymentCompleted { get; set; }

        public virtual Application Application { get; set; }
        public virtual FiscalYear FiscalYear { get; set; }
    }
}

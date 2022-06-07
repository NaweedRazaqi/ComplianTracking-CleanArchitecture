using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class Due
    {
        public long Id { get; set; }
        public int ApplicationId { get; set; }
        public decimal Amount { get; set; }
        public short PaymentTypeId { get; set; }
        public bool IsNew { get; set; }
        public short? NumberOfSurvivor { get; set; }
        public decimal Percentage { get; set; }

        public virtual Application Application { get; set; }
        public virtual PaymentType PaymentType { get; set; }
    }
}

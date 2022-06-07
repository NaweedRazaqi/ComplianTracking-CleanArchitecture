using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class Payable
    {
        public Payable()
        {
            OverPaymentDetail = new HashSet<OverPaymentDetail>();
        }

        public long Id { get; set; }
        public int ApplicationId { get; set; }
        public long BatchId { get; set; }
        public decimal Amount { get; set; }
        public int FiscalYearId { get; set; }
        public short PaymentTypeId { get; set; }
        public short CoA { get; set; }
        public int DueFiscalYearId { get; set; }
        public decimal Due { get; set; }

        public virtual Application Application { get; set; }
        public virtual Batch Batch { get; set; }
        public virtual FiscalYear DueFiscalYear { get; set; }
        public virtual FiscalYear FiscalYear { get; set; }
        public virtual PaymentType PaymentType { get; set; }
        public virtual PayableDetails PayableDetails { get; set; }
        public virtual ICollection<OverPaymentDetail> OverPaymentDetail { get; set; }
    }
}

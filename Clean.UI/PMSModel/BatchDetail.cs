using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class BatchDetail
    {
        public long BatchId { get; set; }
        public short PaymentTypeId { get; set; }

        public virtual Batch Batch { get; set; }
        public virtual PaymentType PaymentType { get; set; }
    }
}

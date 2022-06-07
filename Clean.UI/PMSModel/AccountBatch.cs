using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class AccountBatch
    {
        public long Id { get; set; }
        public int ApplicationId { get; set; }
        public long BatchId { get; set; }

        public virtual Application Application { get; set; }
        public virtual Batch Batch { get; set; }
    }
}

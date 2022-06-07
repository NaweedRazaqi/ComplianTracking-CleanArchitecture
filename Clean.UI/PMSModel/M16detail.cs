using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class M16detail
    {
        public int Id { get; set; }
        public int M16id { get; set; }
        public long BatchId { get; set; }

        public virtual Batch Batch { get; set; }
        public virtual M16 M16 { get; set; }
    }
}

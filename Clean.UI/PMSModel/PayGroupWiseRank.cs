using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class PayGroupWiseRank
    {
        public int Id { get; set; }
        public int PayGroupWiseId { get; set; }
        public int RankId { get; set; }

        public virtual PayGroupWise PayGroupWise { get; set; }
        public virtual Rank Rank { get; set; }
    }
}

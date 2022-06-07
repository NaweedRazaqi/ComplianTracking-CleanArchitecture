using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class PayGroupWiseQueue
    {
        public int Id { get; set; }
        public int PayGroupWiseId { get; set; }
        public DateTime? InQueueTime { get; set; }
        public int StatusId { get; set; }
        public string Description { get; set; }
        public DateTime? CompletedTime { get; set; }
        public DateTime? RegisterDate { get; set; }

        public virtual PayGroupWise PayGroupWise { get; set; }
        public virtual Status Status { get; set; }
    }
}

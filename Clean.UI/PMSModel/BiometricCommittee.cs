using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class BiometricCommittee
    {
        public int Id { get; set; }
        public int ProfileId { get; set; }
        public string Reason { get; set; }
        public DateTime SendDate { get; set; }
        public int StatusId { get; set; }
        public string Decision { get; set; }
        public DateTime? DecisionDate { get; set; }

        public virtual Profile Profile { get; set; }
        public virtual Status Status { get; set; }
    }
}

using App.Domain.Entity.look;
using System;
using System.Collections.Generic;

namespace App.Domain.Entity.Complains
{
    public partial class ProcessTrack
    {
        public int Id { get; set; }
        public int? CaseId { get; set; }
        public int? UnitId { get; set; }
        public int? StatusId { get; set; }

        public virtual Status Status { get; set; }
        public virtual Unit Unit { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class PensionDisability
    {
        public int Id { get; set; }
        public int TypeId { get; set; }
        public short? DisabilityLevelId { get; set; }
        public short DisabilityTypeId { get; set; }
        public short DisabilityPlaceId { get; set; }
        public DateTime IncidentDate { get; set; }
        public string FormNumber { get; set; }
        public string Discription { get; set; }
        public int ProfileId { get; set; }

        public virtual Disability DisabilityLevel { get; set; }
        public virtual Disability DisabilityPlace { get; set; }
        public virtual Disability DisabilityType { get; set; }
        public virtual Profile Profile { get; set; }
        public virtual PensionType Type { get; set; }
    }
}

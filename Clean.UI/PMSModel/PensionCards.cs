using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class PensionCards
    {
        public int Id { get; set; }
        public DateTime PrintDate { get; set; }
        public short CardTypeId { get; set; }
        public int ApplicationId { get; set; }
        public int UserId { get; set; }

        public virtual Application Application { get; set; }
        public virtual PensionCardTypes CardType { get; set; }
    }
}

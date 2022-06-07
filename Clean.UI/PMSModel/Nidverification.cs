using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class Nidverification
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime Date { get; set; }
        public int ProfileId { get; set; }
    }
}

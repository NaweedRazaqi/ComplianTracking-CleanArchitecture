using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class DbobjectObject
    {
        public long Id { get; set; }
        public long? ParentId { get; set; }
        public long? ChildId { get; set; }
    }
}

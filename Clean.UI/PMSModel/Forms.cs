using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class Forms
    {
        public short FormId { get; set; }
        public string Name { get; set; }
        public int LastGeneratedNumber { get; set; }
        public string Description { get; set; }
    }
}

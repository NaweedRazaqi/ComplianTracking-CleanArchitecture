using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class Nidaprovelist
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Nid { get; set; }
        public bool? Status { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string Description { get; set; }
        public string PensionName { get; set; }
        public string PensionFatherName { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class Section
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string NameDari { get; set; }
        public string NamePashto { get; set; }
        public int? OrganizationId { get; set; }
        public bool? IsActive { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class ApplicationType
    {
        public ApplicationType()
        {
            Application = new HashSet<Application>();
        }

        public short Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Application> Application { get; set; }
    }
}

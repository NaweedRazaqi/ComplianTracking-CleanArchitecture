using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class CalculationType
    {
        public CalculationType()
        {
            Result = new HashSet<Result>();
        }

        public short Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Result> Result { get; set; }
    }
}

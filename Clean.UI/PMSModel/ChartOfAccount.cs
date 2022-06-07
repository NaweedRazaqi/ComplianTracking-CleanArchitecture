using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class ChartOfAccount
    {
        public ChartOfAccount()
        {
            Batch = new HashSet<Batch>();
        }

        public short Id { get; set; }
        public string Code { get; set; }
        public string Identifier { get; set; }
        public string IdentifierEnglish { get; set; }
        public short DataCategoryId { get; set; }
        public bool Active { get; set; }
        public int? ServiceTypeId { get; set; }

        public virtual DataCategory DataCategory { get; set; }
        public virtual ServiceType ServiceType { get; set; }
        public virtual ICollection<Batch> Batch { get; set; }
    }
}

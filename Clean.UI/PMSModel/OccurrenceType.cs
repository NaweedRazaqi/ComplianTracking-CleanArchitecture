using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class OccurrenceType
    {
        public OccurrenceType()
        {
            Batch = new HashSet<Batch>();
            PaymentTypeInterval = new HashSet<PaymentTypeInterval>();
        }

        public int Id { get; set; }
        public string EnglishIdentifier { get; set; }
        public string Identifier { get; set; }
        public string SchemaName { get; set; }
        public string DbOjbect { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public short? Value { get; set; }
        public string Condition { get; set; }
        public long? ConditionValue { get; set; }
        public long? ConditionElseValue { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsPercentage { get; set; }

        public virtual ICollection<Batch> Batch { get; set; }
        public virtual ICollection<PaymentTypeInterval> PaymentTypeInterval { get; set; }
    }
}

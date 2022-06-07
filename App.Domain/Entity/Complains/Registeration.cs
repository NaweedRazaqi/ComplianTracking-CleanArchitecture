using App.Domain.Entity.look;
using Clean.Domain.Entity.prc;
using System;
using System.Collections.Generic;

namespace App.Domain.Entity.Complains
{
    public partial class Registeration
    {
        public int Id { get; set; }
        public int ProfileId { get; set; }
        public int ComplainTypeId { get; set; }
        public int? UnitId { get; set; }
        public int? StatusId { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Discription { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string Modifiedby { get; set; }
        public bool? IsLastStep { get; set; }

        public virtual Profile Profile { get; set; }
        public virtual Status Status { get; set; }
        public virtual Unit Unit { get; set; }
        public virtual ComplainType ComplainType { get; set; }
    }
}

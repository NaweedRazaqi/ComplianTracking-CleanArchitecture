using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class Heir
    {
        public Heir()
        {
            MultiplePension = new HashSet<MultiplePension>();
        }

        public int Id { get; set; }
        public int ProfileId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FatherName { get; set; }
        public string GrandFatherName { get; set; }
        public string Nid { get; set; }
        public int DocNoIssuePlace { get; set; }
        public DateTime DocNoIssueDate { get; set; }
        public short GenderId { get; set; }
        public DateTime DoB { get; set; }
        public string PhotoPath { get; set; }
        public short HeirTypeId { get; set; }
        public string DocumentNo { get; set; }
        public short RelativeId { get; set; }
        public short DocumentTypeId { get; set; }
        public bool IsActive { get; set; }
        public string Court { get; set; }
        public int? CountryId { get; set; }
        public string Description { get; set; }

        public virtual Country Country { get; set; }
        public virtual DocumentType DocumentType { get; set; }
        public virtual Gender Gender { get; set; }
        public virtual HeirType HeirType { get; set; }
        public virtual Profile Profile { get; set; }
        public virtual Relative Relative { get; set; }
        public virtual ICollection<MultiplePension> MultiplePension { get; set; }
    }
}

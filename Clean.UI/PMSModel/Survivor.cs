using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class Survivor
    {
        public int Id { get; set; }
        public int ProfileId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FatherName { get; set; }
        public string Nid { get; set; }
        public DateTime DateOfBirth { get; set; }
        public short RelativeId { get; set; }
        public short MaritalStatusId { get; set; }
        public short DocumentTypeId { get; set; }
        public short GenderId { get; set; }
        public short SurvivorStatusId { get; set; }
        public string GrandFatherName { get; set; }

        public virtual DocumentType DocumentType { get; set; }
        public virtual MaritalStatus MaritalStatus { get; set; }
        public virtual Profile Profile { get; set; }
        public virtual Relative Relative { get; set; }
        public virtual SurvivorStatus SurvivorStatus { get; set; }
    }
}

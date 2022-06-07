using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class DocumentType
    {
        public DocumentType()
        {
            Document = new HashSet<Document>();
            Heir = new HashSet<Heir>();
            Profile = new HashSet<Profile>();
            Survivor = new HashSet<Survivor>();
        }

        public short Id { get; set; }
        public string Name { get; set; }
        public string Catagory { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Document> Document { get; set; }
        public virtual ICollection<Heir> Heir { get; set; }
        public virtual ICollection<Profile> Profile { get; set; }
        public virtual ICollection<Survivor> Survivor { get; set; }
    }
}

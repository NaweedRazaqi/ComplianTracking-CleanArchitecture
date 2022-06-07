using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class Screen
    {
        public Screen()
        {
            Document = new HashSet<Document>();
            InverseParent = new HashSet<Screen>();
            Process = new HashSet<Process>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string DirectoryPath { get; set; }
        public string Icon { get; set; }
        public int Sorter { get; set; }
        public int? ParentId { get; set; }
        public short? ModuleId { get; set; }
        public bool? PassIdOnClick { get; set; }

        public virtual Module Module { get; set; }
        public virtual Screen Parent { get; set; }
        public virtual ICollection<Document> Document { get; set; }
        public virtual ICollection<Screen> InverseParent { get; set; }
        public virtual ICollection<Process> Process { get; set; }
    }
}

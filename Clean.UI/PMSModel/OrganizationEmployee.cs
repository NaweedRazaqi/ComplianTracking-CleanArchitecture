using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class OrganizationEmployee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FatherName { get; set; }
        public short EmployeeTypeId { get; set; }
        public int OrganizationId { get; set; }
        public bool? IsActive { get; set; }
        public int? CategoryId { get; set; }

        public virtual EmployeeRank EmployeeType { get; set; }
        public virtual Organization Organization { get; set; }
    }
}

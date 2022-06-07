using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Complains.Models
{
    public class SearchProfileModel
    {
        public int Id { get; set; }
        public string HashKey { get; set; }
        public string Code { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FatherName { get; set; }
        public string Nid { get; set; }
        public short GenderId { get; set; }
        public DateTime DoB { get; set; }
        public string GrandFatherName { get; set; }
        public short DocumentTypeId { get; set; }
        public int BirthLocationId { get; set; }
        public int EducationDegreeId { get; set; }
        public int? OrganizationId { get; set; }
        public int DistrictId { get; set; }
        public int? CensusId { get; set; }
        public int? BiometricId { get; set; }
        public bool IsLife { get; set; }
        public string AccountNumber { get; set; }
    }
}

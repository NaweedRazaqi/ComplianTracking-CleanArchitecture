﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Complains.Models
{
    public class ComplainProcessSearchModel
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string LastName { get; set; }
        public int ProfileId { get; set; }
        public int ComplainTypeId { get; set; }
        public int? UnitId { get; set; }
        public string Discription { get; set; }
        public string ComplainText { get; set; }
        public string UnitText { get; set; }
        public bool? IsLastStep { get; set; }

        public int? LastStepID { get; set; }
    }
}

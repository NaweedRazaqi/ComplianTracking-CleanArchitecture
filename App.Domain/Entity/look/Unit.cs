using App.Domain.Entity.Complains;
using System;
using System.Collections.Generic;

namespace App.Domain.Entity.look
{
    public partial class Unit
    {
        public Unit()
        {
            ProcessTrack = new HashSet<ProcessTrack>();
            Registeration = new HashSet<Registeration>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ProcessTrack> ProcessTrack { get; set; }
        public virtual ICollection<Registeration> Registeration { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class ProcessConnection
    {
        public int Id { get; set; }
        public int ProcessId { get; set; }
        public int ConnectedTo { get; set; }

        public virtual Process ConnectedToNavigation { get; set; }
        public virtual Process Process { get; set; }
    }
}

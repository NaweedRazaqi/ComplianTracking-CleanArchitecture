using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class Token
    {
        public short Id { get; set; }
        public string TokenValue { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}

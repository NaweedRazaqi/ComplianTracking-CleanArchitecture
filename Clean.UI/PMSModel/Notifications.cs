using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class Notifications
    {
        public int Id { get; set; }
        public int? FromId { get; set; }
        public string Message { get; set; }
        public int? AppUserId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? ReadAt { get; set; }
        public int? ScreenId { get; set; }
        public string RecordId { get; set; }
        public string Title { get; set; }
    }
}

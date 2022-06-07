using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class Document
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public string ContentType { get; set; }
        public DateTime? UploadDate { get; set; }
        public string ObjectSchema { get; set; }
        public string ObjectName { get; set; }
        public decimal RecordId { get; set; }
        public string Root { get; set; }
        public string Path { get; set; }
        public string Description { get; set; }
        public string EncryptionKey { get; set; }
        public int? StatusId { get; set; }
        public int? ScreenId { get; set; }
        public DateTime? LastDownloadDate { get; set; }
        public string DocumentNumber { get; set; }
        public string DocumentSource { get; set; }
        public DateTime? DocumentDate { get; set; }
        public short? DocumentTypeId { get; set; }

        public virtual DocumentType DocumentType { get; set; }
        public virtual Screen Screen { get; set; }
        public virtual Status Status { get; set; }
    }
}

using System;
using Newtonsoft.Json;

namespace Dwolla.Client.Models.Requests
{
    public class UploadDocumentRequest
    {
        public string DocumentType { get; set; }
        
        [JsonIgnore]
        public File Document { get; set; }
    }
}
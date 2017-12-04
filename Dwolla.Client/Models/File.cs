using Newtonsoft.Json;
using System.Collections.Generic;

namespace Dwolla.Client.Models
{
    public class File
    {
        public byte[] Bytes { get; set; }

        public string Filename { get; set; }

        public string ContentType { get; set; }
    }
}
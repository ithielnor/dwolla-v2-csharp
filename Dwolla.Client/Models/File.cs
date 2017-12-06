using io = System.IO;

namespace Dwolla.Client.Models
{
    public class File
    {
        public io.Stream Stream { get; set; }

        public string Filename { get; set; }

        public string ContentType { get; set; }
    }
}
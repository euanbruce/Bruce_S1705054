using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    public class UploadModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Client { get; set; }
        public string Description { get; set; }

        public byte[] AudioFile { get; set; }

        public string SenderID { get; set; }
    }
}

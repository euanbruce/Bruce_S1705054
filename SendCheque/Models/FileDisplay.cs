using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SendCheque.Models
{
    public class FileDisplay
    {
        
        public string Title { get; set; }
        public string Client { get; set; }
        public string Description { get; set; }

        public HttpFileCollection File { get; set; }

    }
}
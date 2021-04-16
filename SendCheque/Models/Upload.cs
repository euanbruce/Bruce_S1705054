using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Web;
using NAudio.Wave;

namespace SendCheque.Models
{
    public class Upload
    {
        [Required]
        public string Title { get; set; }

        [Required]
        public string Client { get; set; }

        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Audio File")] 
        [DataType(DataType.Upload)]
        
        public HttpPostedFileBase file { get; set; }

        public char SenderID;

    }
}
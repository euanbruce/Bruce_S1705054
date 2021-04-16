using SendCheque.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataLibrary;
using static DataLibrary.BusinessLogic.AudioFileProcessor;
using System.IO;
using DataLibrary.BusinessLogic;
using DataLibrary.Models;
using Microsoft.AspNet.Identity;

namespace SendCheque.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "About page";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact page.";

            return View();
        }


        [Authorize]
        public ActionResult Upload()
        {
            ViewBag.Message = "Upload Audio";

            return View();
        }

        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public ActionResult Upload(Upload model)
        {

            string fileContent = string.Empty;
            string fileContentType = string.Empty;
            if (ModelState.IsValid)
            {
                // Data to be uploaded.
                UploadModel upload = new UploadModel();
                byte[] uploadedFile = new byte[model.file.InputStream.Length];
                model.file.InputStream.Read(uploadedFile, 0, uploadedFile.Length);

                upload.Title = model.Title;
                upload.Description = model.Description;
                upload.Client = model.Client;
                upload.AudioFile = uploadedFile.ToArray();
                upload.SenderID = User.Identity.GetUserId();
                AudioFileProcessor.CreateUpload(upload);
            }
            return View();
        }

        // Display List of sent files
        [Authorize]
        public ActionResult ViewFiles()
        {
            ViewBag.Message = "View Files";

            var data = LoadAudioFile();
            List<UploadModel> files = new List<UploadModel>();
            files = LoadAudioFile();
          // MemoryStream ms = new MemoryStream(download.AudioFile) 
          /*
            foreach (var row in data)
            {
                files.Add(new UploadModel
               
                {
                    Title = row.Title,
                    Client = row.Client,
                    Description = row.Description,
                    AudioFile = row.AudioFile

                });
            }
          */
          
            return View(files);
        }




        public ActionResult RetrieveFile(int id)
        {
            //    DownloadModel download = new DownloadModel();
            //    FileStream stream = null;
            byte[] songBytes;

            //UploadModel myfile = new UploadModel();
            var data = getAudioFile(id);
            if (data.Count > 0)
            {

                songBytes = data[0].AudioFile;
                System.IO.MemoryStream oMemoryStream = new System.IO.MemoryStream(songBytes);
                FileStreamResult fsresult = new FileStreamResult(oMemoryStream, "audio/mp3");
                return fsresult;
            }
            else
            {
                return null;
            }    

            //    return View();
        }
    }
}   
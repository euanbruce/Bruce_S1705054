using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.BusinessLogic
{
    public static class AudioFileProcessor
    {
        public static int CreateUpload(UploadModel data)
        {
            

            string sql = @"insert into dbo.AudioFiles (Title, Client, Description, AudioFile, SenderID)
                            values (@Title, @Client, @Description, @AudioFile, @SenderID)";

            return SQLDataAccess.SaveData(sql, data);
        }

        
        
        public static List<UploadModel> LoadAudioFile()
        {
            string sql = @"select Id, Id,Title, Client, Description, AudioFile, SenderID 
                           from dbo.AudioFiles;";

            return SQLDataAccess.LoadData<UploadModel>(sql);
        }

        public static List<UploadModel> getAudioFile(int id)
        {
            string sql = @"select AudioFile
                           from dbo.AudioFiles
                            where Id = " + id.ToString();

            return SQLDataAccess.LoadData<UploadModel>(sql);
        }

    }
    
}

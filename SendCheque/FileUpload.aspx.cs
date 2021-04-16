using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.IO;


namespace SendCheque
{
    public partial class FileUpload : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void UploadFile()
        {
            byte[] sound;

            Stream stream = AudioFile.PostedFile.InputStream;
            BinaryReader br = new BinaryReader(stream);
            sound = br.ReadBytes((Int32)stream.Length);


            SqlConnection con = new SqlConnection("data source=.\\SQLEXPRESS; initial catalog= aspnet-SendCheque-20210402010052; integrated security = true ");
            SqlCommand com = new SqlCommand("insert into AudioFile values(@data)");
            com.Connection = con;
            com.Parameters.AddWithValue("@data", sound);

            con.Open();
            int result = com.ExecuteNonQuery();
            if (result > 0)
                LabelError.Text = "Success";
            else
                LabelError.Text = "Failed";

            con.Close();
        }

        protected void btn_Upload_Click(object sender, EventArgs e)
        {
            UploadFile();
        }
    }
}
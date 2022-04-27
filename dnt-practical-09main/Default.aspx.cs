using System;
using System.Collections.Generic;
using System.IO;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical9
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            displayImages();
        }
        protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
        {

        }

        protected void Upload(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                if (FileUpload1.FileName.EndsWith("png") || FileUpload1.FileName.EndsWith("jpg") || FileUpload1.FileName.EndsWith("jpeg"))
                {
                    string fileName = Path.GetFileName(FileUpload1.PostedFile.FileName);
                    FileUpload1.PostedFile.SaveAs(Server.MapPath("~/Images/") + fileName);
                    Response.Redirect(Request.Url.AbsoluteUri);
                }
            }
        }

        void displayImages()
        {
            string[] filePaths = Directory.GetFiles(Server.MapPath("~/Images/"));
            ListItemCollection files = new ListItemCollection();
            foreach (string filePath in filePaths)
            {
                string fileName = Path.GetFileName(filePath);
                files.Add(new ListItem(fileName, "~/Images/" + fileName));

            }
            GridView1.DataSource = files;
            GridView1.DataBind();
        }
    }
}

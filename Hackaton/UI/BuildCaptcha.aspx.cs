using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Text;

namespace UI
{
    public partial class BuildCaptcha : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            Bitmap objBMP = new Bitmap(60, 20);
            Graphics objGraphics = Graphics.FromImage(objBMP);
            objGraphics.Clear(Color.Wheat);
            objGraphics.TextRenderingHint = TextRenderingHint.AntiAlias;
            Font objFont = new Font("Arial", 8, FontStyle.Italic);
            string randomStr = "";
            char[] myArray = new char[5];
            int x;
            Random autoRand = new Random();
            for (x = 0; x < 5; x++)
            {
                myArray[x] = System.Convert.ToChar(autoRand.Next(65, 90));
                randomStr += (myArray[x].ToString());
            }
            Session.Add("RandomStr", randomStr);
            objGraphics.DrawString(randomStr, objFont, Brushes.Red, 3, 3);
            Response.ContentType = "image/GIF";
            objBMP.Save(Response.OutputStream, ImageFormat.Gif);
            objFont.Dispose();
            objGraphics.Dispose();
            objBMP.Dispose();
        }
    }
}
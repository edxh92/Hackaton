using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BLL;
namespace UI
{
    public partial class Registro1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        string archivo = "";
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (Page.IsValid && (txtCaptcha.Text.ToString() == Session["RandomStr"].ToString()))
            {
                Response.Write("Code verificacition");
                ClasslLog l = new ClasslLog();
                try
                {
                    string mensaje = l.Ingresar(TextBox1.Text, TextBox3.Text, TextBox2.Text, "1");
                }
                catch (Exception)
                {

                    throw;
                }
            }
            else
            {
                Response.Write("Please enter infor");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            bool corre = false;
            if (FileUpload1.HasFile)
            {
                string extencion = System.IO.Path.GetExtension(FileUpload1.FileName).ToLower();
                string[] extencionesPermitidas = { ".png", ".jpg", ".jpeg" };
                for (int i = 0; i < extencionesPermitidas.Length; i++)
                {
                    if (extencion == extencionesPermitidas[i])
                    {
                        corre = true;
                    }
                }
            }
            if (corre)
            {
                ViewState["foto"] = System.IO.Path.GetFileName(FileUpload1.FileName);
                FileUpload1.SaveAs(Server.MapPath("~/") + ViewState["foto"]);
                archivo = FileUpload1.FileName;
                Image1.ImageUrl = "~/" + ViewState["foto"];
                Image1.DataBind();
            }
        }
    }
}
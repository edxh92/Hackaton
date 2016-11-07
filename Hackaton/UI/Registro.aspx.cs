using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI
{
    public partial class Registro1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (Page.IsValid && (txtCaptcha.Text.ToString() == Session["RandomStr"].ToString()))
            {
                Response.Write("Code verificacition");
            }
            else
            {
                Response.Write("Please enter infor");
            }
        }
    }
}
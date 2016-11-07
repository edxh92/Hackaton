using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Data;
namespace UI
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ClasslLog log = new ClasslLog();
            DataTable tabla = log.Inicio(TextBox1.Text, TextBox2.Text);
            if (tabla.Rows.Count >0)
            {
                Response.Redirect("~/Contact.aspx");
            }
            else
            {
                Response.Redirect("~/login.aspx");
            }
        }
    }
}
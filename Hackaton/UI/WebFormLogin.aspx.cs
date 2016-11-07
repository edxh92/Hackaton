using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
namespace UI
{
    public partial class WebFormLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ClasslLog LgInicio = new ClasslLog();
            this.GridView1.DataSource = LgInicio.Inicio(this.TextBox1.Text, this.TextBox2.Text);
            this.GridView1.DataBind();
            if (this.GridView1.Rows.Count > 0)
            {
                Session["usuario"] = TextBox1.Text;
                Response.Redirect("WebFormFarmaciaNew.aspx");
            }
            else
            {
                Response.Redirect("WebFormLog.aspx");
            }
        }
    }
}
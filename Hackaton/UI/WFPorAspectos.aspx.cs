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
    public partial class WFPorAspectos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ClassIncidente lgincidente = new ClassIncidente();
            DataTable tabla = new DataTable();
            if(TextBox1.Text=="")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Llene los campos');</script>");
            }
            else
            {
                tabla = lgincidente.porAspecto(TextBox1.Text);
                if (tabla.Rows.Count == 0)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('No Existe ese registro');</script>");
                }
                else
                {
                    this.GridView1.DataSource = tabla;
                    this.GridView1.DataBind();
                }
            }
           
           
        }
    }
}
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
    public partial class wfAgregarIncidente : System.Web.UI.Page
    {
        DataTable dt; 
        protected void Page_Load(object sender, EventArgs e)
        {
           if(!IsPostBack)
            {
                dt = new DataTable();
                dt.Columns.Add("Id");
                dt.Columns.Add("nombre");
                dt.Columns.Add("descripcion");
                dt = (DataTable)Session["tipos"];
             
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            ClassTipoIncidente lg = new ClassTipoIncidente();
        dt=   lg.Buscar(TextBox1.Text);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            Session["tipos"] = dt;

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ClassTipoIncidente lg = new ClassTipoIncidente();
            GridView1.DataSource = lg.Buscar(TextBox1.Text);
            GridView1.DataBind();

        }
    }
}
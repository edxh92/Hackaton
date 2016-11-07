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
            if (!IsPostBack)
            {
                dt = new DataTable();
                dt.Columns.Add("Id");
                dt.Columns.Add("nombre");
                dt.Columns.Add("descripcion");
                ClassTipoIncidente lg = new ClassTipoIncidente();
                DataTable tb = lg.Listar();
                DropDownList1.DataSource = tb;
                DropDownList1.DataValueField = tb.Columns["idTipoIncidente"].ToString();
                DropDownList1.DataTextField = tb.Columns["nombreTipo"].ToString();
                DropDownList1.DataBind();
            }
             
            }
        

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
          

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            lblTipoIncidente.Text = DropDownList1.SelectedValue;
            ClassIncidente lg = new ClassIncidente();
           // lg.InsertarIncidente(DropDownList2.SelectedValue.ToString(),)
        }
    }
}
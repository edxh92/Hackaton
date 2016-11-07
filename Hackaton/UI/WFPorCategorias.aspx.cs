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
    public partial class WFPorCategorias : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
             

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ClassIncidente lgincidente = new ClassIncidente();
            DataTable tabla = new DataTable();
            tabla = lgincidente.PorCategoria(TextBox1.Text);
            if(tabla.Rows.Count==0)
            {
                Label3.Text = "No existe esa categoria";
            }
          
            else 
            {
                this.GridView1.DataSource = tabla;
                this.GridView1.DataBind();
            }
        }
    }
}